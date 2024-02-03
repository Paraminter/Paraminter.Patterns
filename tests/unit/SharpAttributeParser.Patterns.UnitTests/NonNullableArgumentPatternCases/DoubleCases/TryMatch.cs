namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.DoubleCases;

using Moq;

using OneOf;
using OneOf.Types;

using Xunit;

public sealed class TryMatch
{
    private static OneOf<Error, double> Target(IArgumentPattern<double> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Double_0_ResultsInMatch() => ResultsInMatch(0, 0d);

    [Fact]
    public void Double_Pi_ResultsInMatch() => ResultsInMatch(3.14, 3.14);

    [Fact]
    public void Double_NegativeE_ResultsInMatch() => ResultsInMatch(-2.718, -2.718);

    [Fact]
    public void Int_ResultsInError() => ResultsInError(0);

    [Fact]
    public void Float_ResultsInError() => ResultsInError(0f);

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(double expected, object? argument)
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
