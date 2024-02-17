namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.BoolCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static PatternMatchResult<bool> Target(IArgumentPattern<bool> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Bool_True_ResultsInMatch() => ResultsInMatch(true, true);

    [Fact]
    public void Bool_False_ResultsInMatch() => ResultsInMatch(false, false);

    [Fact]
    public void Int_ResultsInError() => ResultsInError(0);

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(bool expected, object? argument)
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
