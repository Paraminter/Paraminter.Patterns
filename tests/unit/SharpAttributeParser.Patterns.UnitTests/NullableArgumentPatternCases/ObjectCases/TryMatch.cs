namespace SharpAttributeParser.Patterns.NullableArgumentPatternCases.ObjectCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static PatternMatchResult<object?> Target(IArgumentPattern<object?> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Object_ResultsInMatch()
    {
        var argument = Mock.Of<object>();

        ResultsInMatch(argument, argument);
    }

    [Fact]
    public void String_ResultsInMatch() => ResultsInMatch(string.Empty, string.Empty);

    [Fact]
    public void Int_ResultsInMatch() => ResultsInMatch(0, 0);

    [Fact]
    public void Null_ResultsInMatch() => ResultsInMatch(null, null);

    [AssertionMethod]
    private static void ResultsInMatch(object? expected, object? argument)
    {
        var result = Target(Context.Pattern, argument);

        Assert.Equal(expected, result.GetMatchedArgument());
    }
}
