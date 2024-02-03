namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.FloatCases;

using Moq;

using OneOf;
using OneOf.Types;

using Xunit;

public sealed class TryMatch
{
    private static OneOf<Error, float> Target(IArgumentPattern<float> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Float_0_ResultsInMatch() => ResultsInMatch(0, 0f);

    [Fact]
    public void Float_Pi_ResultsInMatch() => ResultsInMatch(3.14f, 3.14f);

    [Fact]
    public void Float_NegativeE_ResultsInMatch() => ResultsInMatch(-2.718f, -2.718f);

    [Fact]
    public void Int_ResultsInError() => ResultsInError(0);

    [Fact]
    public void Double_ResultsInError() => ResultsInError(0d);

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(float expected, object? argument)
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
