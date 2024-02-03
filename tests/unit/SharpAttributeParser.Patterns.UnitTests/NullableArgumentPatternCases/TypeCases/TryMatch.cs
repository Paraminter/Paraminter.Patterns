namespace SharpAttributeParser.Patterns.NullableArgumentPatternCases.TypeCases;

using Microsoft.CodeAnalysis;

using Moq;

using OneOf;
using OneOf.Types;

using Xunit;

public sealed class TryMatch
{
    private static OneOf<Error, ITypeSymbol?> Target(IArgumentPattern<ITypeSymbol?> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Type_ResultsInMatch()
    {
        var argument = Mock.Of<ITypeSymbol>();

        ResultsInMatch(argument, argument);
    }

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInMatch() => ResultsInMatch(null, null);

    [AssertionMethod]
    private static void ResultsInMatch(ITypeSymbol? expected, object? argument)
    {
        var result = Target(Context.Pattern, argument);

        Assert.Equal(expected, result.AsT1);
    }

    [AssertionMethod]
    private static void ResultsInError(object? argument)
    {
        var result = Target(Context.Pattern, argument);

        Assert.Equal(new Error(), result);
    }
}
