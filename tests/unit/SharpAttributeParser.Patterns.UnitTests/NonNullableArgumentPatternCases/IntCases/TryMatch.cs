namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.IntCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static PatternMatchResult<int> Target(IArgumentPattern<int> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Int_0_ResultsInMatch() => ResultsInMatch(0, 0);

    [Fact]
    public void Int_1_ResultsInMatch() => ResultsInMatch(1, 1);

    [Fact]
    public void Int_Negative1_ResultsInMatch() => ResultsInMatch(-1, -1);

    [Fact]
    public void Short_ResultsInError() => ResultsInError((short)0);

    [Fact]
    public void Long_ResultsInError() => ResultsInError((long)0);

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(int expected, object? argument)
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
