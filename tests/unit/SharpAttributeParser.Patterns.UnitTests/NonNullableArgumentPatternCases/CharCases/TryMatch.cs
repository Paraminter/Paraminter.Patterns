namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.CharCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static PatternMatchResult<char> Target(IArgumentPattern<char> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Char_0_ResultsInMatch() => ResultsInMatch('0', '0');

    [Fact]
    public void Char_1_ResultsInMatch() => ResultsInMatch((char)1, (char)1);

    [Fact]
    public void Byte_ResultsInError() => ResultsInError((byte)0);

    [Fact]
    public void Int_ResultsInError() => ResultsInError(0);

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(char expected, object? argument)
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
