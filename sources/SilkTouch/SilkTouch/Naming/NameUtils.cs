using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Humanizer;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.FindSymbols;

using Project = Microsoft.CodeAnalysis.Project;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Mods;
using System.Collections.Concurrent;
using Silk.NET.SilkTouch.Utility;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Contains utilities used throughout the naming namespace.
/// </summary>
[SuppressMessage("ReSharper", "LoopCanBeConvertedToQuery")]
public static partial class NameUtils
{
    /// <summary>
    /// An instance of <see cref="SearchValues{T}"/> matching ASCII capital letters.
    /// </summary>
    public static readonly SearchValues<char> Uppercase = SearchValues.Create(
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    );

    /// <summary>
    /// An instance of <see cref="SearchValues{T}"/> matching ASCII lowercase letters and numbers.
    /// </summary>
    public static readonly SearchValues<char> NotUppercase = SearchValues.Create(
        "abcdefghijklmnopqrstuvwxyz0123456789"
    );

    /// <summary>
    /// An instance of <see cref="SearchValues{T}"/> matching ASCII letters, numbers, and an underscore.
    /// </summary>
    public static readonly SearchValues<char> IdentifierChars = SearchValues.Create(
        "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_"
    );

    /// <summary>
    /// Prettifies the given string.
    /// </summary>
    /// <param name="str">The string to prettify.</param>
    /// <param name="transformer">
    /// The transformer that mutates a humanised string before being converted back to pascal case.
    /// </param>
    /// <param name="allowAllCaps">Whether the output is allowed to be fully capitalised ("all caps").</param>
    /// <returns>The pretty string.</returns>
    public static string Prettify(
        this string str,
        ICulturedStringTransformer transformer,
        bool allowAllCaps = false
    )
    {
        var ret = string.Join(
            null,
            str.LenientUnderscore()
                .Humanize()
                .Transform(transformer)
                .Pascalize()
                .Where(x => char.IsLetter(x) || char.IsNumber(x))
        );
        var retSpan = ret.AsSpan();
        if (!allowAllCaps && retSpan.IndexOfAny(NotUppercase) == -1)
        {
            Span<char> caps = stackalloc char[retSpan.Length - 1];
            retSpan[1..].ToLower(caps, CultureInfo.InvariantCulture);
            ret = $"{ret[0]}{caps}";
        }
        return !char.IsLetter(ret[0]) ? $"X{ret}" : ret;
    }

    /// <summary>
    /// Finds a common prefix in a set of names with respect to the word boundaries
    /// </summary>
    /// <param name="names">Set of names, snake_case</param>
    /// <param name="allowFullMatch">Allows result to be a a full match with one of the names</param>
    /// <param name="allowLeadingDigits">Allows remainder tokens to start with a digit</param>
    /// <param name="naive">
    /// Just match the start of the strings, don't bother checking for obvious name separation gaps.
    /// </param>
    /// <returns>String that is common between all provided names</returns>
    public static string FindCommonPrefix(
        IReadOnlyCollection<string> names,
        bool allowFullMatch,
        bool allowLeadingDigits,
        bool naive = false
    )
    {
        if (allowFullMatch && names.Count == 1)
        {
            return names.First();
        }

        var commonPrefixFirstPass = FindCommonPrefix(
            names,
            allowFullMatch,
            names.Max(x => x.Length),
            naive
        );
        if (allowLeadingDigits)
        {
            return commonPrefixFirstPass;
        }

        var tgtPos = commonPrefixFirstPass.Length;

        var startingWithDigit = names.Where(n => n.Length > tgtPos && char.IsDigit(n[tgtPos]));
        return startingWithDigit.Any()
            ? FindCommonPrefix(names, allowFullMatch, tgtPos - 1, naive)
            : commonPrefixFirstPass;
    }

    /// <summary>
    /// Finds a common prefix in a set of names with respect to the word boundaries
    /// </summary>
    /// <param name="names">Set of names, snake_case</param>
    /// <param name="allowFullMatch">Allows result to be a a full match with one of the names</param>
    /// <param name="maxLen">Match length limit</param>
    /// <param name="naive">
    /// Just match the start of the strings, don't bother checking for obvious name separation gaps.
    /// </param>
    /// <returns>String that is common between all provided names</returns>
    public static string FindCommonPrefix(
        IReadOnlyCollection<string> names,
        bool allowFullMatch,
        int maxLen,
        bool naive = false
    )
    {
        var pos = 0;
        var foundPrefix = "";
        var minLen = names.Min(x => x.Length);
        var found = false;
        var firstName = names.First();
        while (!found)
        {
            pos++;
            if (pos > (naive ? maxLen : maxLen - 1) || pos > (naive ? minLen : firstName.Length))
            {
                break;
            }

            var prefix = firstName[..pos];
            foreach (var name in names)
            {
                if (name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                found = true;
                break;
            }

            if (pos > 1 && !found) // if pos is smaller, that means we haven't even done a full loop yet and already tripped up.
            {
                foundPrefix = prefix;
            }
        }

        if (!naive && !foundPrefix.Contains('_'))
        {
            return "";
        }

        if (foundPrefix.Length == minLen && allowFullMatch)
        {
            return foundPrefix;
        }

        // @Perksey says: Originally I added a -1 here in the naive case in #2020 because it felt like it was wrong
        // (why would we want the prefix to be equal to something we *know* isn't applicable to all
        // names?) and was producing one specific bad result for which there is now a regression test.
        // If this is having catastrophic impacts on other bindings then please reverse this change and
        // find a smarter fix.
        //
        // It turns out however there were other cases where this wasn't doing what it should, for instance finding the
        // prefix between Silk.NET.SDL and Silk.NET.SDL with allowFullMatch set (i.e. the result should be Silk.NET.SDL)
        // so instead a naive case was added in the while loop itself, changing to
        // `if (pos > (naive ? maxLen : maxLen - 1)...` so that it should hopefully have the same effect and then some.
        // This was done in #2207. I guess this was the smarter fix my previous comment was talking about.
        return foundPrefix[..(naive ? foundPrefix.Length : foundPrefix.LastIndexOf('_') + 1)];
    }

    /// <summary>
    /// Separates the input words with underscore
    /// </summary>
    /// <param name="input">The string to be underscored</param>
    /// <returns></returns>
    public static string LenientUnderscore(this string input) =>
        // This is a modified version of Humanizer's Underscore methods with the following changes:
        // - The regex ([\p{Ll}\d])([\p{Lu}]) has been replaced with
        //   ([\p{Ll}\d])(?=[\p{Lu}][\p{Lu}\p{Ll}])([\p{Lu}]) - In this regex, the positive lookahead assertion
        //   (?=[\p{Lu}][\p{Lu}\p{Ll}]) ensures that the next character after the match is an uppercase letter,
        //   followed by any letter (uppercase or lowercase). This will only match if the 2nd character after the
        //   initial match is uppercase. That was suggested by ChatGPT, a human had to add the final
        //   [\p{Ll}])([\p{Lu}]) to ensure we don't erroneous match non-pascal case strings and to capture the
        //   second character to ensure we can do the replacement. Still pretty smart though.
        // - The final ToLower has been omitted as it was not deemed necessary
        // - The regex ([\p{Ll}])([\p{Lu}]) has been added to replace lowercase letters followed by an uppercase letter with the
        //   same sequence but with an underscore inbetween,
        //   this fixes cases like SpvImageFormatR32ui being Spv_Image_FormatR32ui instead of Spv_Image_Format_R32ui
        KebabOrSpace()
            .Replace(
                LowerUpper()
                    .Replace(
                        LowerUpperAnyUpper()
                            .Replace(LowerUpperLower().Replace(input, "$1_$2"), "$1_$2"),
                        "$1_$2"
                    ),
                "_"
            );

    [GeneratedRegex(@"[-\s]")]
    private static partial Regex KebabOrSpace();

    [GeneratedRegex(@"([\p{Ll}])([\p{Lu}])")]
    private static partial Regex LowerUpper();

    [GeneratedRegex(@"([\p{Ll}])(?=[\p{Lu}][\p{Lu}\p{Ll}])([\p{Lu}])")]
    private static partial Regex LowerUpperAnyUpper();

    [GeneratedRegex(@"([\p{Lu}]+)([\p{Lu}][\p{Ll}])")]
    private static partial Regex LowerUpperLower();

    internal partial class NameTransformer(int longAcronymThreshold) : ICulturedStringTransformer
    {
        public string Transform(string input) => Transform(input, null);

        public string Transform(string input, CultureInfo? culture)
        {
            culture ??= CultureInfo.CurrentCulture;

            var matches = Words().Split(input);
            for (var i = 0; i < matches.Length; i++)
            {
                ref var word = ref matches[i];
                if (string.IsNullOrWhiteSpace(word))
                {
                    continue;
                }
                if (
                    word.Length > longAcronymThreshold
                    || !AllCapitals(word)
                    || (
                        AllCapitals(input)
                        && input.Length > longAcronymThreshold
                        && matches.Length > 1
                    )
                )
                {
                    word = MakeFirstLetterUpper(word, culture);
                }

                for (var j = i - 1; j >= 0; j--)
                {
                    if (string.IsNullOrWhiteSpace(matches[j]))
                    {
                        continue;
                    }
                    if (i > 0 && char.IsDigit(word[0]) && char.IsDigit(matches[j][^1]))
                    {
                        word = $"x{word}";
                    }

                    break;
                }
            }

            return string.Join(" ", matches);
        }

        private static bool AllCapitals(string input) =>
            input.ToCharArray().All(x => char.IsUpper(x) || !char.IsLetter(x));

        private static string MakeFirstLetterUpper(string wordToConvert, CultureInfo culture)
        {
            var nextLetter = wordToConvert.TakeWhile(char.IsDigit).Count() + 1;
            if (nextLetter > wordToConvert.Length)
            {
                // It's not a word?
                return wordToConvert;
            }

            return culture.TextInfo.ToUpper(wordToConvert[..nextLetter])
                + culture.TextInfo.ToLower(wordToConvert.Remove(0, nextLetter));
        }

        // https://chat.openai.com/share/f5eb195b-96a4-4f0f-955b-9d08b976a955
        // https://chat.openai.com/share/8d3f2ec4-7eec-4dbd-a01e-a8d73e885964
        [GeneratedRegex(@"(?<=\D)(?=\d)|(?<=\d)(?=\D)|\W+")]
        private static partial Regex Words();
    }

    private static Location? IdentifierLocation(SyntaxNode? node) =>
        node switch {
            BaseTypeDeclarationSyntax bt => bt.Identifier.GetLocation(),
            DelegateDeclarationSyntax d => d.Identifier.GetLocation(),
            EnumMemberDeclarationSyntax em => em.Identifier.GetLocation(),
            EventDeclarationSyntax e => e.Identifier.GetLocation(),
            MethodDeclarationSyntax m => m.Identifier.GetLocation(),
            PropertyDeclarationSyntax p => p.Identifier.GetLocation(),
            VariableDeclaratorSyntax v => v.Identifier.GetLocation(),
            ConstructorDeclarationSyntax c => c.Identifier.GetLocation(),
            DestructorDeclarationSyntax d => d.Identifier.GetLocation(),
            _ => null
        };

    /// <summary>
    /// Rename all symbols with the given new names
    /// </summary>
    /// <param name="ctx">Mod context to use</param>
    /// <param name="toRename">list of symbols to rename with new names</param>
    /// <param name="ct">cancellation token</param>
    /// <param name="logger">logger</param>
    /// <param name="includeDeclarations">whether to replace any declaration references or not</param>
    /// <param name="includeCandidateLocations">should candidate references or implicit references be included</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static async Task RenameAllAsync<T>(
        IModContext ctx,
        ILogger<T> logger,
        IEnumerable<(ISymbol Symbol, string NewName)> toRename,
        CancellationToken ct = default,
        bool includeDeclarations = true,
        bool includeCandidateLocations = false
    )
    {
        if (ctx.SourceProject is null)
        {
            return;
        }

        var locations = new ConcurrentDictionary<Location, string>();
        // TODO this needs parallelisation config & be sensitive to the environment (future src generator form factor?)
        await Parallel.ForEachAsync(
            toRename,
            ct,
            async (tuple, _) => {
                // First, let's add all of the locations of the declaration identifiers.
                var (symbol, newName) = tuple;
                if (includeDeclarations)
                {
                    foreach (var syntaxRef in symbol.DeclaringSyntaxReferences)
                    {
                        var identifierLocation = IdentifierLocation(await syntaxRef.GetSyntaxAsync(ct));
                        if (identifierLocation is not null)
                        {
                            locations.TryAdd(identifierLocation, newName);
                        }
                    }
                }

                // Next, let's find all the references of the symbols.
                var references = await SymbolFinder.FindReferencesAsync(
                    symbol,
                    ctx.SourceProject?.Solution
                        ?? throw new ArgumentException("SourceProject is null"),
                    ct
                );

                foreach (var referencedSymbol in references)
                {
                    foreach (var referencedSymbolLocation in referencedSymbol.Locations)
                    {
                        if (!includeCandidateLocations &&
                            (referencedSymbolLocation.IsCandidateLocation
                            || referencedSymbolLocation.IsImplicit)
                        )
                        {
                            continue;
                        }

                        locations.TryAdd(referencedSymbolLocation.Location, newName);
                    }
                }
            }
        );

        logger.LogDebug("{} referencing locations for renames for {}", locations.Count, ctx.JobKey);

        // Now it's just a simple find and replace.
        var sln = ctx.SourceProject.Solution;
        var srcProjId = ctx.SourceProject.Id;
        var testProjId = ctx.TestProject?.Id;
        foreach (
            var (syntaxTree, renameLocations) in locations
                .GroupBy(x => x.Key.SourceTree)
                .Select(x => (x.Key, x.OrderByDescending(y => y.Key.SourceSpan)))
        )
        {
            if (
                syntaxTree is null
                || sln.GetDocument(syntaxTree) is not { } doc
                || (doc.Project.Id != srcProjId && doc.Project.Id != testProjId)
                || await syntaxTree.GetTextAsync(ct) is not { } text
            )
            {
                continue;
            }

            var ogText = text;
            foreach (var (location, newName) in renameLocations)
            {
                var contents = ogText.GetSubText(location.SourceSpan).ToString();
                if (contents.Contains(' '))
                {
                    logger.LogWarning(
                        "Refusing to do unsafe rename/replacement of \"{}\" to \"{}\" at {}",
                        contents,
                        newName,
                        location.GetLineSpan()
                    );
                    continue;
                }

                if (logger.IsEnabled(LogLevel.Trace))
                {
                    logger.LogTrace(
                        "\"{}\" -> \"{}\" at {}",
                        contents,
                        newName,
                        location.GetLineSpan()
                    );
                }

                text = text.Replace(location.SourceSpan, newName);
            }

            sln = doc.WithText(text).Project.Solution;
        }

        ctx.SourceProject = sln.GetProject(srcProjId);
    }
}
