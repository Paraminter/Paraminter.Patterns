namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.ByteCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static PatternMatchResult<byte> Target(IArgumentPattern<byte> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Byte_0_ResultsInMatch() => ResultsInMatch(0, (byte)0);

    [Fact]
    public void Byte_1_ResultsInMatch() => ResultsInMatch(1, (byte)1);

    [Fact]
    public void Int_ResultsInError() => ResultsInError(0);

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(byte expected, object? argument)
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
