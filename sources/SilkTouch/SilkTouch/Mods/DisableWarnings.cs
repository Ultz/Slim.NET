// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods
{
    /// <summary>
    /// A mod to Add warning disabling pragmas
    /// </summary>
    /// <param name="config">The configuration to use.</param>
    [ModConfiguration<Configuration>]
    public class DisableWarnings(IOptionsSnapshot<DisableWarnings.Configuration> config) : Mod
    {
        /// <summary>
        /// The configuration for the <see cref="DisableWarnings"/> mod.
        /// </summary>
        public class Configuration
        {
            /// <summary>
            /// Warning Codes to Disable
            /// </summary>
            public string[]? WarningCodes { get; init; }
        }

        /// <inheritdoc />
        public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
        {
            await base.ExecuteAsync(ctx, ct);

            // Read the configuration.
            var cfg = config.Get(ctx.JobKey);

            if (cfg.WarningCodes is null)
            {
                return;
            }

            // Create the pragma directive trivia
            var pragmaDirective = Trivia(
                PragmaWarningDirectiveTrivia(Token(SyntaxKind.DisableKeyword), true)
                    .WithErrorCodes(
                        SeparatedList<ExpressionSyntax>(
                            cfg.WarningCodes.Select(warn => IdentifierName(warn))
                        )
                    )
            );

            ctx.SourceProject = await DisableWarningsAsync(ctx.SourceProject, pragmaDirective, ct);
            ctx.TestProject = await DisableWarningsAsync(ctx.TestProject, pragmaDirective, ct);
        }

        private async Task<Microsoft.CodeAnalysis.Project?> DisableWarningsAsync(
            Microsoft.CodeAnalysis.Project? proj,
            SyntaxTrivia pragmaDirective,
            CancellationToken ct
        )
        {
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                var doc =
                    proj?.GetDocument(docId)
                    ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                // Find the using directive
                SyntaxNode? namespaceNode = root.DescendantNodes()
                    .OfType<FileScopedNamespaceDeclarationSyntax>()
                    .FirstOrDefault();

                if (namespaceNode == null)
                {
                    // Skip the case where no using directive is found
                    continue;
                }

                // Get the leading trivia (comments) of the first using directive
                var leadingTrivia = namespaceNode.GetLeadingTrivia();

                // Insert the pragma directive after the comments
                var newLeadingTrivia = leadingTrivia
                    .Insert(leadingTrivia.Count, pragmaDirective)
                    .Add(CarriageReturnLineFeed);

                // Update the using directive with the new leading trivia
                var newUsingDirective = namespaceNode.WithLeadingTrivia(newLeadingTrivia);

                // Replace the old using directive with the new one in the root node
                root = root.ReplaceNode(namespaceNode, newUsingDirective);
                doc = doc.WithSyntaxRoot(root);

                proj = doc.Project;
            }
            return proj;
        }
    }
}
