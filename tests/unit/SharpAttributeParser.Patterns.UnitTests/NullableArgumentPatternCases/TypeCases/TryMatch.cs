namespace SharpAttributeParser.Patterns.NullableArgumentPatternCases.TypeCases;

using Microsoft.CodeAnalysis;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static PatternMatchResult<ITypeSymbol?> Target(IArgumentPattern<ITypeSymbol?> pattern, object? argument) => pattern.TryMatch(argument);

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

        Assert.Equal(expected, result.GetMatchedArgument());
    }

    [AssertionMethod]
    private static void ResultsInError(object? argument)
    {
        var result = Target(Context.Pattern, argument);

        Assert.False(result.WasSuccessful);
    }
}
