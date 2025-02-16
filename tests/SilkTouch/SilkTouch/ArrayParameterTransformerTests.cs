// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NUnit.Framework;
using Silk.NET.SilkTouch.Mods.Metadata;
using Silk.NET.SilkTouch.Mods.Transformation;

namespace Silk.NET.SilkTouch.UnitTests;

[TestFixture]
public class ArrayParameterTransformerTests
{
    [
        Test,
        TestCase(
            // Delete, immutable, in set
            // Normal case
            """
                public static void DeleteTests(int cnt, [NativeTypeName("const uint*")] uint* testi)
                    => InnerDeleteTest(cnt, testi);
                """,
            """
                public static void DeleteTest([NativeTypeName("const uint*")] uint testi)
                {
                    InnerDeleteTest(1, (uint*)&testi);
                }
                """
        ),
        TestCase(
            // Create, mutable, out set
            // Normal case
            """
                public static void CreateTests(int cnt, [NativeTypeName("uint*")] uint* testmo)
                    => InnerCreateTest(cnt, testmo);
                """,
            """
                public static uint CreateTest()
                {
                    uint testmo = default;
                    InnerCreateTest(1, (uint*)&testmo);
                    return testmo;
                }
                """
        ),
        TestCase(
            // Delete, immutable, in set, 1 count
            // Normal case - this is probably a poor example though
            """
                public static void DeleteTests([NativeTypeName("const uint*")] uint* test1i)
                    => InnerDeleteTest(test1i);
                """,
            """
                public static void DeleteTest([NativeTypeName("const uint*")] uint test1i)
                {
                    InnerDeleteTest((uint*)&test1i);
                }
                """
        ),
        TestCase(
            // Create, mutable, out set, 1 count
            // Normal case
            """
                public static void CreateTests([NativeTypeName("uint*")] uint* test1mo)
                    => InnerCreateTest(test1mo);
                """,
            """
                public static uint CreateTest()
                {
                    uint test1mo = default;
                    InnerCreateTest((uint*)&test1mo);
                    return test1mo;
                }
                """
        ),
        TestCase(
            // Create, mutable, out NOT set
            // Boundary case (when both IsOut and IsIn are unset, we fall back on benefit of doubt logic)
            """
                public static void CreateTests(int cnt, [NativeTypeName("uint*")] uint* testm)
                    => InnerCreateTest(cnt, testm);
                """,
            """
                public static uint CreateTest()
                {
                    uint testm = default;
                    InnerCreateTest(1, (uint*)&testm);
                    return testm;
                }
                """
        ),
        TestCase(
            // Delete, immutable, in NOT set
            // Boundary case (when both IsOut and IsIn are unset, we fall back on benefit of doubt logic)
            """
                public static void DeleteTests(int cnt, [NativeTypeName("const uint*")] uint* test)
                    => InnerDeleteTest(cnt, test);
                """,
            """
                public static void DeleteTest([NativeTypeName("const uint*")] uint test)
                {
                    InnerDeleteTest(1, (uint*)&test);
                }
                """
        ),
        TestCase(
            // Create, mutable, no count/flow information whatsoever
            // Benefit of doubt case
            """
                public static void CreateTests(int cnt, [NativeTypeName("uint*")] uint* tst)
                    => InnerCreateTest(cnt, tst);
                """,
            """
                public static uint CreateTest()
                {
                    uint tst = default;
                    InnerCreateTest(1, (uint*)&tst);
                    return tst;
                }
                """
        ),
        TestCase(
            // Delete, immutable, no count/flow information whatsoever
            // Benefit of doubt case
            """
                public static void DeleteTests(int cnt, [NativeTypeName("const uint*")] uint* tst)
                    => InnerDeleteTest(cnt, tst);
                """,
            """
                public static void DeleteTest([NativeTypeName("const uint*")] uint tst)
                {
                    InnerDeleteTest(1, (uint*)&tst);
                }
                """
        ),
        TestCase(
            // Both in and out
            // Bad case
            """
                public static void DeleteTests(int cnt, [NativeTypeName("const uint*")] uint* testio)
                    => InnerDeleteTest(cnt, testio);
                """,
            """
                public static void DeleteTests(int cnt, [NativeTypeName("const uint*")] uint* testio) => InnerDeleteTest(cnt, testio);
                """
        ),
        TestCase(
            // Usage constraints is input but native info indicates mutable.
            // Bad case
            """
                public static void DeleteTests(int cnt, [NativeTypeName("uint*")] uint* testi)
                    => InnerDeleteTest(cnt, testi);
                """,
            """
                public static void DeleteTests(int cnt, [NativeTypeName("uint*")] uint* testi) => InnerDeleteTest(cnt, testi);
                """
        ),
        TestCase(
            // Usage constraints is input but count indicates mutable.
            // Bad case
            """
                public static void DeleteTests(int cnt, [NativeTypeName("const uint*")] uint* testim)
                    => InnerDeleteTest(cnt, testim);
                """,
            """
                public static void DeleteTests(int cnt, [NativeTypeName("const uint*")] uint* testim) => InnerDeleteTest(cnt, testim);
                """
        ),
        TestCase(
            // Usage constraints is output but native info indicates immutable.
            // Bad case
            """
                public static void DeleteTests(int cnt, [NativeTypeName("const uint*")] uint* testom)
                    => InnerDeleteTest(cnt, testom);
                """,
            """
                public static void DeleteTests(int cnt, [NativeTypeName("const uint*")] uint* testom) => InnerDeleteTest(cnt, testom);
                """
        ),
        TestCase(
            // Usage constraints is output but count indicates immutable.
            // Bad case
            """
                public static void DeleteTests(int cnt, [NativeTypeName("const uint*")] uint* testo)
                    => InnerDeleteTest(cnt, testo);
                """,
            """
                public static void DeleteTests(int cnt, [NativeTypeName("const uint*")] uint* testo) => InnerDeleteTest(cnt, testo);
                """
        )
    ]
    public void Transform(string originalMethod, string expectedMethod)
    {
        var og =
            SyntaxFactory.ParseMemberDeclaration(originalMethod) as MethodDeclarationSyntax
            ?? throw new InvalidOperationException("failed to cast original");
        var uut = new ArrayParameterTransformer(null);
        var result = og;
        uut.Transform(og, false, new TestApiMetadata { Original = og }, (x, isInInterface) => result = x);
        Assert.That(
            result.NormalizeWhitespace().ToFullString().ReplaceLineEndings(),
            Is.EqualTo(expectedMethod.ReplaceLineEndings())
        );
    }

    class TestApiMetadata
        : IFunctionTransformer,
            ITransformationContext,
            IApiMetadataProvider<SymbolConstraints>
    {
        public TestApiMetadata() => Transformers = [this];

        public MethodDeclarationSyntax Transform(
            MethodDeclarationSyntax current,
            bool isInInterface,
            ITransformationContext ctx,
            Func<MethodDeclarationSyntax, bool, MethodDeclarationSyntax> next
        ) => throw new NotImplementedException();

        public string? JobKey { get; set; }
        public MethodDeclarationSyntax? Original { get; set; }
        public IFunctionTransformer[]? Transformers { get; set; }

        public bool AddUsing(UsingDirectiveSyntax use) => throw new NotImplementedException();

        public bool TryGetChildSymbolMetadata(
            string? jobKey,
            string nativeName,
            string childNativeName,
            [NotNullWhen(true)] out SymbolConstraints? metadata
        )
        {
            if (childNativeName.StartsWith("test1"))
            {
                metadata = new SymbolConstraints(
                    [
                        new LogicalAnnotation<UsageConstraints>(
                            LogicalRequirement.Always,
                            null,
                            null,
                            null,
                            new UsageConstraints(
                                StaticCount: 1,
                                IsOut: childNativeName.Contains('o'),
                                IsIn: childNativeName.Contains('i')
                            )
                        )
                    ],
                    ElementTypeConstraints: new SymbolConstraints(
                        [
                            new LogicalAnnotation<UsageConstraints>(
                                LogicalRequirement.Always,
                                null,
                                null,
                                null,
                                new UsageConstraints()
                            )
                        ]
                    ),
                    IsMutable: childNativeName.Contains('m')
                );
                return true;
            }

            if (childNativeName.StartsWith("test"))
            {
                metadata = new SymbolConstraints(
                    [
                        new LogicalAnnotation<UsageConstraints>(
                            LogicalRequirement.Always,
                            null,
                            null,
                            null,
                            new UsageConstraints(
                                CountExpression: "cnt",
                                IsOut: childNativeName.Contains('o'),
                                IsIn: childNativeName.Contains('i')
                            )
                        )
                    ],
                    ElementTypeConstraints: new SymbolConstraints(
                        [
                            new LogicalAnnotation<UsageConstraints>(
                                LogicalRequirement.Always,
                                null,
                                null,
                                null,
                                new UsageConstraints()
                            )
                        ]
                    ),
                    IsMutable: childNativeName.Contains('m')
                );
                return true;
            }

            metadata = default;
            return false;
        }
    }
}
