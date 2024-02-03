namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.LongCases;

using Moq;

using OneOf;
using OneOf.Types;

using Xunit;

public sealed class TryMatch
{
    private static OneOf<Error, long> Target(IArgumentPattern<long> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Long_0_ResultsInMatch() => ResultsInMatch(0, (long)0);

    [Fact]
    public void Long_1_ResultsInMatch() => ResultsInMatch(1, (long)1);

    [Fact]
    public void Long_Negative1_ResultsInMatch() => ResultsInMatch(-1, (long)-1);

    [Fact]
    public void Int_ResultsInError() => ResultsInError(0);

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(long expected, object? argument)
    {
        var result = Target(Context.Pattern, argument);

        Assert.Equal(expected, result);
    }

    [AssertionMethod]
    private static void ResultsInError(object? argument)
    {
        var result = Target(Context.Pattern, argument);

        Assert.Equal(new Error(), result);
    }
}
