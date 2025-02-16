using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Common utilities useful to mods.
/// </summary>
public static class ModUtils
{
    /// <summary>
    /// Converts a namespace string into an <see cref="NameSyntax"/>.
    /// </summary>
    /// <param name="ns">The namespace string.</param>
    /// <returns>The <see cref="NameSyntax"/> representing this namespace.</returns>
    public static NameSyntax NamespaceIntoIdentifierName(ReadOnlySpan<char> ns)
    {
        var idx = ns.LastIndexOf('.');
        if (idx == -1)
        {
            return IdentifierName(ns.ToString());
        }

        return QualifiedName(
            NamespaceIntoIdentifierName(ns[..idx]),
            IdentifierName(ns[(idx + 1)..].ToString())
        );
    }

    /// <summary>
    /// Gets the namespace in which a syntax node is contained. This is transitive, so nested namespace declarations
    /// will be accounted for.
    /// </summary>
    /// <param name="node">The syntax node.</param>
    /// <returns>The namespace.</returns>
    public static string NamespaceFromSyntaxNode(this SyntaxNode node) =>
        string.Join(
            '.',
            node.Ancestors()
                .OfType<BaseNamespaceDeclarationSyntax>()
                .Reverse()
                .Select(x => x.Name.ToString())
        );

    /// <summary>
    /// Gets the namespace in which a symbol is contained.
    /// </summary>
    /// <param name="symbol">The symbol.</param>
    /// <returns>The namespace.</returns>
    public static string NamespaceFromSymbol(this ISymbol? symbol) =>
        symbol is INamespaceSymbol
            ? NamespaceFromSymbol(symbol.ContainingNamespace) is { Length: > 0 } parent
                ? $"{parent}.{symbol.Name}"
                : symbol.Name
            // ReSharper disable once TailRecursiveCall <-- this is more code than we need
            : symbol?.ContainingNamespace is not null
                ? NamespaceFromSymbol(symbol.ContainingNamespace)
                : string.Empty;

    /// <summary>
    /// Matches a potential replacement candidate against the given list of regex-replacement mappings and, if a regex
    /// matches, performs a group substitution on the replacement to replace the match.
    /// </summary>
    /// <param name="mappings">
    /// Regex-to-replacement mappings. The replacements can have group references that will get substituted in (e.g.
    /// <c>"Silk.NET.$1</c>)
    /// </param>
    /// <param name="candidate">The string to run the replacement on.</param>
    /// <returns>The replaced string. It may not have been modified at all.</returns>
    public static string GroupedRegexReplace(
        IEnumerable<(Regex Regex, string Replacement)> mappings,
        string candidate
    )
    {
        foreach (var (regex, replacement) in mappings)
        {
            var match = regex.Match(candidate);
            if (!match.Success)
            {
                continue;
            }

            candidate = replacement;
            for (var i = 0; i < match.Groups.Count; i++)
            {
                candidate = candidate.Replace($"${i}", match.Groups[i].Value);
            }
        }

        return candidate;
    }

    /// <summary>
    /// Gets a string that can be used to discriminate a type for baking purposes.
    /// </summary>
    /// <param name="toks">Tokens e.g. ref, in, out.</param>
    /// <param name="type">The type syntax.</param>
    /// <returns>The discriminator string.</returns>
    public static string DiscrimStr(SyntaxTokenList? toks, TypeSyntax? type) =>
        toks?.Any(x =>
            x.Kind() is SyntaxKind.RefKeyword or SyntaxKind.InKeyword or SyntaxKind.OutKeyword
        ) ?? false
            ? $"{type}&"
            : type?.ToString() ?? string.Empty;

    /// <summary>
    /// Gets a string that can be used to discriminate a function-like element for baking purposes.
    /// </summary>
    /// <param name="modifiers">The modifiers on the function.</param>
    /// <param name="tParams">The type parameters.</param>
    /// <param name="identifier">The name of the function.</param>
    /// <param name="params">The parameters of the function.</param>
    /// <param name="returnType">The return type of the function.</param>
    /// <returns>The discriminator string.</returns>
    public static string DiscrimStr(
        SyntaxTokenList? modifiers,
        TypeParameterListSyntax? tParams,
        ReadOnlySpan<char> identifier,
        IEnumerable<BaseParameterSyntax>? @params,
        TypeSyntax? returnType
    ) =>
        ((modifiers?.Any(SyntaxKind.StaticKeyword) ?? false ? "static " : string.Empty)
        + $"{DiscrimStr(modifiers, returnType)} {identifier}{tParams}"
        + $"({string.Join(", ", @params?.Select(DiscrimStr) ?? Enumerable.Empty<string>())})")
        .Replace(" ", "");

    /// <summary>
    /// Gets a string that can be used to discriminate a function-like element for baking purposes.
    /// </summary>
    /// <param name="modifiers">The modifiers on the function.</param>
    /// <param name="tParams">The type parameters.</param>
    /// <param name="identifier">The name of the function.</param>
    /// <param name="params">The parameters of the function.</param>
    /// <param name="returnType">The return type of the function.</param>
    /// <returns>The discriminator string.</returns>
    public static string DiscrimStr(
        SyntaxTokenList? modifiers,
        TypeParameterListSyntax? tParams,
        ReadOnlySpan<char> identifier,
        BaseParameterListSyntax? @params,
        TypeSyntax? returnType
    ) => DiscrimStr(modifiers, tParams, identifier, @params?.Parameters, returnType);

    /// <summary>
    /// Gets a string that can be used to discriminate a single parameter.
    /// </summary>
    /// <param name="param">The parameter.</param>
    /// <returns>The discriminator string.</returns>
    public static string DiscrimStr(BaseParameterSyntax param) =>
        DiscrimStr(param.Modifiers, param.Type);

    /// <summary>
    /// Modifies the <see cref="DllImportAttribute"/>s the method may have to make them resistant to method identifier
    /// changes.
    /// </summary>
    /// <param name="node">The original method.</param>
    /// <returns>The modified method.</returns>
    public static MethodDeclarationSyntax WithRenameSafeAttributeLists(
        this MethodDeclarationSyntax node
    ) =>
        node.WithAttributeLists(
            List(
                node.AttributeLists.Select(x =>
                    x.WithAttributes(
                        SeparatedList(
                            x.Attributes.Select(y =>
                                y.IsAttribute("System.Runtime.InteropServices.DllImport")
                                && (
                                    y.ArgumentList?.Arguments.All(z =>
                                        z.NameEquals?.Name.ToString() != "EntryPoint"
                                    ) ?? true
                                )
                                    ? y.AddArgumentListArguments(
                                        AttributeArgument(
                                                LiteralExpression(
                                                    SyntaxKind.StringLiteralExpression,
                                                    Literal(node.Identifier.ToString())
                                                )
                                            )
                                            .WithNameEquals(NameEquals("EntryPoint"))
                                    )
                                    : y
                            )
                        )
                    )
                )
            )
        );

    /// <summary>
    /// Gets the relative path for this document.
    /// </summary>
    /// <param name="doc">The document.</param>
    /// <returns>The relative path.</returns>
    public static string? RelativePath(this Document doc)
    {
        if (
            doc.FilePath is null
            || doc.Project.FilePath is null
            || Path.GetDirectoryName(doc.Project.FilePath) is not { Length: > 0 } dir
        )
        {
            return default;
        }

        var ret = Path.GetRelativePath(dir, doc.FilePath);
        return ret.StartsWith("..") ? default : ret.Replace('\\', '/').Trim('/');
    }

    /// <summary>
    /// Converts a relative path into a full path for a project.
    /// </summary>
    /// <param name="proj">The project.</param>
    /// <param name="relativePath">The relative path.</param>
    /// <returns>The full path. Upon failure, null is returned.</returns>
    public static string FullPath(this Project proj, string relativePath) =>
        Path.GetDirectoryName(proj.FilePath) is { Length: > 0 } dir
            ? Path.GetFullPath(relativePath, dir)
            : relativePath;

    /// <summary>
    /// Gets the new <see cref="ISymbol"/> matching the given old <see cref="ISymbol"/> in a new
    /// <see cref="Compilation"/>. This is useful for maintaining context after a mutating operation e.g. for getting a
    /// new type symbol instance after a rename operation.
    /// </summary>
    /// <param name="newCompilation">The new compilation.</param>
    /// <param name="oldSymbol">The symbol in the old compilation.</param>
    /// <param name="newName">The new <see cref="ISymbol.Name"/> of the symbol, if changed.</param>
    /// <returns>The new symbol.</returns>
    /// <exception cref="ArgumentException">
    /// <paramref name="oldSymbol"/> was not part of the <see cref="Compilation"/> it was originally sourced from (i.e.
    /// it is a reference of a foreign type or otherwise did not have an <see cref="ISourceAssemblySymbol"/> ancestor).
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// <paramref name="oldSymbol"/> or one of its ancestors did not have a matching symbol in
    /// <paramref name="newCompilation"/>.
    /// </exception>
    public static ISymbol GetNewSymbol(
        this Compilation newCompilation,
        ISymbol oldSymbol,
        string? newName = null
    )
    {
        // Get all of the symbols we need to find.
        // This is "reversed" because the last item of the path we need to follow comes first.
        var oldPathReversed = oldSymbol.AncestorsAndSelf().ToArray();
        if (oldPathReversed[^1] is not ISourceAssemblySymbol)
        {
            throw new ArgumentException(
                "The given symbol was not part of the assembly represented by the Compilation i.e. it does not "
                    + "have ISourceAssemblySymbol as an ancestor.",
                nameof(oldSymbol)
            );
        }

        // Start from the compilation's assembly and walk down.
        var expectedEndMdName = newName is null
            ? oldSymbol.MetadataName
            : oldSymbol.MetadataName.Replace(oldSymbol.Name, newName);
        ISymbol current = newCompilation.Assembly;
        Debug.Assert(current is ISourceAssemblySymbol);

        // ------------------------------------vvv-------------- because we're skipping the source assembly.
        for (var i = oldPathReversed.Length - 2; i >= 0; i--)
        {
            var currentOld = oldPathReversed[i];
            var expectedMdName = i == 0 ? expectedEndMdName : currentOld.MetadataName;
            current =
                current.Members().FirstOrDefault(x => x.MetadataName == expectedMdName)
                ?? throw new InvalidOperationException($"Could not find \"{expectedMdName}\".");
        }

        return current;
    }

    private static IEnumerable<ISymbol> AncestorsAndSelf(this ISymbol sym)
    {
        do
        {
            yield return sym;
        } while ((sym = sym!.ContainingSymbol!) is not null);
    }

    /// <summary>
    /// Enumerates the members of the given symbol.
    /// </summary>
    /// <param name="sym">The symbol.</param>
    /// <returns>The member symbols.</returns>
    public static IEnumerable<ISymbol> Members(this ISymbol sym) =>
        sym switch
        {
            IAssemblySymbol assemblySymbol => assemblySymbol.Modules,
            IModuleSymbol moduleSymbol => [moduleSymbol.GlobalNamespace],
            INamespaceOrTypeSymbol namespaceOrTypeSymbol => namespaceOrTypeSymbol.GetMembers(),
            _ => [],
        };

    private static IEnumerable<ISymbol> Descendants(this ISymbol sym) =>
        sym.Members().SelectMany(x => x.Descendants());

    /// <summary>
    /// Gets the "effective name" of a given file name. That is, the path without its extension but with any dot
    /// suffixes that begin with a capital letter and therefore are conceivably part of the effective file name.
    /// </summary>
    /// <param name="fullKey">The full path.</param>
    /// <param name="effectiveName">The effective name within <paramref name="fullKey"/>.</param>
    /// <param name="directory">The directory within <paramref name="fullKey"/>.</param>
    /// <param name="remainder">The trailing characters after <paramref name="effectiveName"/>.</param>
    public static void GetEffectiveName(
        this ReadOnlySpan<char> fullKey,
        out ReadOnlySpan<char> effectiveName,
        out ReadOnlySpan<char> directory,
        out ReadOnlySpan<char> remainder
    )
    {
        directory = Path.GetDirectoryName(fullKey);
        effectiveName = fullKey[directory.Length..];
        while (effectiveName[0] is '/' or '\\')
        {
            directory = fullKey[..(directory.Length + 1)];
            effectiveName = effectiveName[1..];
        }

        // effective name of GL.gen.cs is GL but effective name of something like GL.Manual.cs or GL.Interfaces.gen.cs
        // is GL.Manual or GL.Interfaces respectively
        remainder = default;
        while (effectiveName.LastIndexOf('.') is not -1 and var lastIdx)
        {
            if (char.IsUpper(effectiveName[lastIdx + 1]))
            {
                break;
            }

            remainder = fullKey[(directory.Length + lastIdx)..];
            effectiveName = effectiveName[..lastIdx];
        }
    }

    /// <summary>
    /// Gets the "effective name" of a given file name. That is, the path without its extension but with any dot
    /// suffixes that begin with a capital letter and therefore are conceivably part of the effective file name.
    /// </summary>
    /// <param name="fullKey">The full path.</param>
    /// <returns>The effective name.</returns>
    public static ReadOnlySpan<char> GetEffectiveName(this ReadOnlySpan<char> fullKey)
    {
        fullKey.GetEffectiveName(out var ret, out _, out _);
        return ret;
    }

    /// <summary>
    /// Adds a suffix to the effective name contained within the given path, and returns the full path with the suffix
    /// added.
    /// </summary>
    /// <param name="fullKey">The full path.</param>
    /// <param name="suffix">The suffix.</param>
    /// <returns></returns>
    public static string AddEffectiveSuffix(
        this ReadOnlySpan<char> fullKey,
        ReadOnlySpan<char> suffix
    )
    {
        fullKey.GetEffectiveName(out var effectiveName, out var directory, out var remainder);
        return $"{directory}{effectiveName}.{suffix}{remainder}";
    }

    /// <summary>
    /// Reconstructs the <see cref="PInvokeGeneratorConfigurationOptions"/> from the given
    /// <see cref="PInvokeGeneratorConfiguration"/> because this is a PITA to do manually.
    /// </summary>
    /// <param name="cfg">The ClangSharp config.</param>
    /// <returns>The options contained within.</returns>
    public static PInvokeGeneratorConfigurationOptions ReconstructOptions(
        this PInvokeGeneratorConfiguration cfg
    )
    {
        var options = PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.DontUseUsingStaticsForEnums
            ? PInvokeGeneratorConfigurationOptions.DontUseUsingStaticsForEnums
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeAnonymousFieldHelpers
            ? PInvokeGeneratorConfigurationOptions.ExcludeAnonymousFieldHelpers
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeComProxies
            ? PInvokeGeneratorConfigurationOptions.ExcludeComProxies
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeEmptyRecords
            ? PInvokeGeneratorConfigurationOptions.ExcludeEmptyRecords
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeEnumOperators
            ? PInvokeGeneratorConfigurationOptions.ExcludeEnumOperators
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeFnptrCodegen
            ? PInvokeGeneratorConfigurationOptions.ExcludeFnptrCodegen
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeFunctionsWithBody
            ? PInvokeGeneratorConfigurationOptions.ExcludeFunctionsWithBody
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.ExcludeNIntCodegen
            ? PInvokeGeneratorConfigurationOptions.ExcludeNIntCodegen
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateAggressiveInlining
            ? PInvokeGeneratorConfigurationOptions.GenerateAggressiveInlining
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateCompatibleCode
            ? PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateCppAttributes
            ? PInvokeGeneratorConfigurationOptions.GenerateCppAttributes
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateDocIncludes
            ? PInvokeGeneratorConfigurationOptions.GenerateDocIncludes
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateExplicitVtbls
            ? PInvokeGeneratorConfigurationOptions.GenerateExplicitVtbls
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateFileScopedNamespaces
            ? PInvokeGeneratorConfigurationOptions.GenerateFileScopedNamespaces
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateGuidMember
            ? PInvokeGeneratorConfigurationOptions.GenerateGuidMember
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateHelperTypes
            ? PInvokeGeneratorConfigurationOptions.GenerateHelperTypes
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateLatestCode
            ? PInvokeGeneratorConfigurationOptions.GenerateLatestCode
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateMacroBindings
            ? PInvokeGeneratorConfigurationOptions.GenerateMacroBindings
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateMarkerInterfaces
            ? PInvokeGeneratorConfigurationOptions.GenerateMarkerInterfaces
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateMultipleFiles
            ? PInvokeGeneratorConfigurationOptions.GenerateMultipleFiles
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateNativeBitfieldAttribute
            ? PInvokeGeneratorConfigurationOptions.GenerateNativeBitfieldAttribute
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateNativeInheritanceAttribute
            ? PInvokeGeneratorConfigurationOptions.GenerateNativeInheritanceAttribute
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GeneratePreviewCode
            ? PInvokeGeneratorConfigurationOptions.GeneratePreviewCode
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateSetsLastSystemErrorAttribute
            ? PInvokeGeneratorConfigurationOptions.GenerateSetsLastSystemErrorAttribute
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateSourceLocationAttribute
            ? PInvokeGeneratorConfigurationOptions.GenerateSourceLocationAttribute
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateTemplateBindings
            ? PInvokeGeneratorConfigurationOptions.GenerateTemplateBindings
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateTestsNUnit
            ? PInvokeGeneratorConfigurationOptions.GenerateTestsNUnit
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateTestsXUnit
            ? PInvokeGeneratorConfigurationOptions.GenerateTestsXUnit
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateTrimmableVtbls
            ? PInvokeGeneratorConfigurationOptions.GenerateTrimmableVtbls
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateUnixTypes
            ? PInvokeGeneratorConfigurationOptions.GenerateUnixTypes
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateUnmanagedConstants
            ? PInvokeGeneratorConfigurationOptions.GenerateUnmanagedConstants
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.GenerateVtblIndexAttribute
            ? PInvokeGeneratorConfigurationOptions.GenerateVtblIndexAttribute
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.LogExclusions
            ? PInvokeGeneratorConfigurationOptions.LogExclusions
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.LogPotentialTypedefRemappings
            ? PInvokeGeneratorConfigurationOptions.LogPotentialTypedefRemappings
            : PInvokeGeneratorConfigurationOptions.None;
        options |= cfg.LogVisitedFiles
            ? PInvokeGeneratorConfigurationOptions.LogVisitedFiles
            : PInvokeGeneratorConfigurationOptions.None;
        if ((options & PInvokeGeneratorConfigurationOptions.GeneratePreviewCode) != 0)
        {
            options &= ~PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
            options &= ~PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
        }
        if ((options & PInvokeGeneratorConfigurationOptions.GenerateLatestCode) != 0)
        {
            options &= ~PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
            options &= ~PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
        }
        if ((options & PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode) != 0)
        {
            options &= ~PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
            options &= ~PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
        }
        return options;
    }

    /// <summary>
    /// Determines (naively) whether the given attribute syntax represents a <see cref="DllImportAttribute"/>.
    /// </summary>
    /// <param name="node">The attribute syntax.</param>
    /// <param name="fullNameWithoutSuffix">
    /// The fully-qualified attribute name including the namespace but without the <c>Attribute</c> suffix.
    /// </param>
    /// <returns>Whether it is probably a DllImport.</returns>
    public static bool IsAttribute(this AttributeSyntax node, string fullNameWithoutSuffix)
    {
        var sep = node.Name.ToString().Split("::").Last();
        var name = fullNameWithoutSuffix.Split('.').Last();
        return sep == name
            || sep == $"{name}Attribute"
            || sep.EndsWith(fullNameWithoutSuffix)
            || sep.EndsWith($"{fullNameWithoutSuffix}Attribute");
    }

    /// <summary>
    /// Adds <see cref="MaxOpt"/> to the given <see cref="MethodDeclarationSyntax"/>'s attribute lists.
    /// </summary>
    /// <param name="meth">The method.</param>
    /// <returns>The modified method.</returns>
    public static MethodDeclarationSyntax AddMaxOpt(this MethodDeclarationSyntax meth) =>
        meth.AddAttributeLists(MaxOpt);

    /// <summary>
    /// Gets the library name and entry-point for the given attribute list, or returns false if this is not a native
    /// interop function.
    /// </summary>
    /// <param name="attrLists">The attribute lists.</param>
    /// <param name="libraryName">The library name.</param>
    /// <param name="entryPoint">The entry-point.</param>
    /// <param name="callConv">The calling convention (if any).</param>
    /// <returns>Whether the native function info was found.</returns>
    public static bool GetNativeFunctionInfo(
        this IEnumerable<AttributeListSyntax> attrLists,
        [NotNullWhen(true)] out string? libraryName,
        out string? entryPoint,
        out string? callConv
    )
    {
        foreach (
            var attr in from attrList in attrLists
            from attr in attrList.Attributes
            where
                attr.IsAttribute("System.Runtime.InteropServices.DllImport")
                || attr.IsAttribute("Silk.NET.Core.NativeFunction")
            select attr
        )
        {
            libraryName =
                (attr.ArgumentList?.Arguments.First().Expression as LiteralExpressionSyntax)
                    ?.Token
                    .ValueText
                ?? throw new InvalidOperationException("DllImport was found but was not valid");
            entryPoint = (
                attr.ArgumentList?.Arguments.FirstOrDefault(x =>
                    x.NameEquals is not null
                    && x.NameEquals.Name.ToString() == nameof(DllImportAttribute.EntryPoint)
                )?.Expression as LiteralExpressionSyntax
            )
                ?.Token
                .ValueText;
            callConv = (
                attr.ArgumentList?.Arguments.FirstOrDefault(x =>
                    x.NameEquals is not null
                    && x.NameEquals.Name.ToString() == nameof(DllImportAttribute.CallingConvention)
                )?.Expression as MemberAccessExpressionSyntax
            )?.Name.ToString();
            return true;
        }

        libraryName = entryPoint = callConv = null;
        return false;
    }

    /// <summary>
    /// Adds a NativeFunctionAttribute if a <see cref="DllImportAttribute"/> is present on the
    /// <paramref name="original"/>.
    /// </summary>
    /// <param name="meth">The method to modify.</param>
    /// <param name="original">The original method.</param>
    /// <returns>The (possibly) modified method.</returns>
    /// <exception cref="InvalidOperationException">If a DllImportAttribute was found but wasn't valid.</exception>
    public static MethodDeclarationSyntax AddNativeFunction(
        this MethodDeclarationSyntax meth,
        MethodDeclarationSyntax original
    )
    {
        if (
            original.AttributeLists.GetNativeFunctionInfo(
                out var libName,
                out var entryPoint,
                out _
            )
        )
        {
            return meth.AddAttributeLists(
                AttributeList(
                    SingletonSeparatedList(
                        Attribute(IdentifierName("NativeFunction"))
                            .WithArgumentList(
                                AttributeArgumentList(
                                    SeparatedList(
                                        new[]
                                        {
                                            AttributeArgument(
                                                LiteralExpression(
                                                    SyntaxKind.StringLiteralExpression,
                                                    Literal(libName)
                                                )
                                            ),
                                            AttributeArgument(
                                                    LiteralExpression(
                                                        SyntaxKind.StringLiteralExpression,
                                                        Literal(
                                                            entryPoint ?? meth.Identifier.ToString()
                                                        )
                                                    )
                                                )
                                                .WithNameEquals(NameEquals("EntryPoint")),
                                        }
                                    )
                                )
                            )
                    )
                )
            );
        }

        return meth;
    }

    /// <summary>
    /// Retrieves the native type name within the given attribute list.
    /// </summary>
    /// <param name="attrs">The attributes.</param>
    /// <param name="requireContext">The required attribute target/context.</param>
    /// <returns>The native type name.</returns>
    public static string? GetNativeTypeName(
        this IEnumerable<AttributeListSyntax> attrs,
        SyntaxKind? requireContext = null
    ) =>
        attrs
            .SelectMany(x =>
                (x.Target is null && requireContext is null)
                || (requireContext is { } rc && (x.Target?.Identifier.IsKind(rc) ?? false))
                    ? x.Attributes
                    : Enumerable.Empty<AttributeSyntax>()
            )
            .FirstOrDefault(x => x.IsAttribute("Silk.NET.Core.NativeTypeName"))
            ?.ArgumentList?.Arguments.Select(x =>
                x.Expression.IsKind(SyntaxKind.StringLiteralExpression)
                    ? (x.Expression as LiteralExpressionSyntax)?.Token.Value
                    : null
            )
            .OfType<string>()
            .FirstOrDefault();

    /// <summary>
    /// Gets the native element type name indicated by the given attributes.
    /// </summary>
    /// <param name="attrs">The attributes.</param>
    /// <param name="indirectionLevels">The expected number of indirection levels, for validation.</param>
    /// <returns>The value if a valid type name was found, null otherwise.</returns>
    public static string? GetNativeElementTypeName(
        this IEnumerable<AttributeListSyntax> attrs,
        out int indirectionLevels
    )
    {
        var nativeTypeName = attrs.GetNativeTypeName().AsSpan();
        if (nativeTypeName.Length == 0)
        {
            indirectionLevels = -1;
            return null;
        }

        // Trim off the const.
        if (nativeTypeName.StartsWith("const "))
        {
            nativeTypeName = nativeTypeName["const ".Length..];
        }

        // Isolate the type name to just the type name.
        indirectionLevels = nativeTypeName.Count('*');
        if (nativeTypeName.IndexOf('*') is not -1 and var idx)
        {
            nativeTypeName = nativeTypeName[..idx];
        }

        // Hopefully given the above, after we've removed any whitespace there may be we *should* just have the enum.
        nativeTypeName = nativeTypeName.Trim();
        return nativeTypeName.ContainsAnyExcept(NameUtils.IdentifierChars)
            ? null
            : nativeTypeName.ToString();
    }

    /// <summary>
    /// Gets a native type name for a parameter.
    /// </summary>
    /// <param name="syntax">The parameter.</param>
    /// <returns>The native type name.</returns>
    public static string? GetNativeTypeName(this ParameterSyntax syntax) =>
        syntax.AttributeLists.GetNativeTypeName();

    /// <summary>
    /// Gets a native type name for the return type of a method.
    /// </summary>
    /// <param name="syntax">The method.</param>
    /// <returns>The native type name.</returns>
    public static string? GetNativeReturnTypeName(this BaseMethodDeclarationSyntax syntax) =>
        syntax.AttributeLists.GetNativeTypeName(SyntaxKind.ReturnKeyword);

    /// <summary>
    /// Determines whether this is a <see cref="PredefinedTypeSyntax"/> representing an integral type.
    /// </summary>
    /// <param name="syn">The type to check.</param>
    /// <returns>Whether it's an integer.</returns>
    public static bool IsInteger(this TypeSyntax syn) =>
        (syn as PredefinedTypeSyntax)?.Keyword.Kind()
            is SyntaxKind.ULongKeyword
                or SyntaxKind.LongKeyword
                or SyntaxKind.UIntKeyword
                or SyntaxKind.IntKeyword
                or SyntaxKind.UShortKeyword
                or SyntaxKind.ShortKeyword
                or SyntaxKind.ByteKeyword
                or SyntaxKind.SByteKeyword;

    /// <summary>
    /// Gets all of the identifiers within the given identifiable member syntax.
    /// </summary>
    /// <param name="syn">The member with the identifiers.</param>
    /// <returns>The identifiers.</returns>
    public static IEnumerable<string> MemberIdentifiers(this MemberDeclarationSyntax syn) =>
        syn switch
        {
            BaseFieldDeclarationSyntax fld => fld.Declaration.Variables.Select(x =>
                x.Identifier.ToString()
            ),
            MethodDeclarationSyntax meth => [meth.Identifier.ToString()],
            BaseNamespaceDeclarationSyntax nsd => [nsd.Name.ToString()],
            EventDeclarationSyntax ev => [ev.Identifier.ToString()],
            PropertyDeclarationSyntax prop => [prop.Identifier.ToString()],
            BaseTypeDeclarationSyntax typ => [typ.Identifier.ToString()],
            DelegateDeclarationSyntax del => [del.Identifier.ToString()],
            EnumMemberDeclarationSyntax em => [em.Identifier.ToString()],
            _ => [],
        };

    /// <summary>
    /// Gets an attribute list representing a <see cref="System.Runtime.CompilerServices.MethodImplAttribute"/> with
    /// <see cref="System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining"/> and
    /// <see cref="System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization"/> set.
    /// </summary>
    public static readonly AttributeListSyntax MaxOpt = AttributeList(
        SingletonSeparatedList(
            Attribute(IdentifierName("MethodImpl"))
                .WithArgumentList(
                    AttributeArgumentList(
                        SingletonSeparatedList(
                            AttributeArgument(
                                BinaryExpression(
                                    SyntaxKind.BitwiseOrExpression,
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("MethodImplOptions"),
                                        IdentifierName("AggressiveInlining")
                                    ),
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("MethodImplOptions"),
                                        IdentifierName("AggressiveOptimization")
                                    )
                                )
                            )
                        )
                    )
                )
        )
    );
}
