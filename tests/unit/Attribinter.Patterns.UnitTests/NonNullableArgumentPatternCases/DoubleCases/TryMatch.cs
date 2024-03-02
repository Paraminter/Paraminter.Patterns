namespace Attribinter.Patterns.NonNullableArgumentPatternCases.DoubleCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<double> Target(IArgumentPattern<double> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Double_0_Successful() => Successful(0, 0d);

    [Fact]
    public void Double_Pi_Successful() => Successful(3.14, 3.14);

    [Fact]
    public void Double_NegativeE_Successful() => Successful(-2.718, -2.718);

    [Fact]
    public void Int_Unsuccessful() => Unsuccessful(0);

    [Fact]
    public void Float_Unsuccessful() => Unsuccessful(0f);

    [Fact]
    public void Object_Unsuccessful() => Unsuccessful(Mock.Of<object>());

    [Fact]
    public void Null_Unsuccessful() => Unsuccessful(null);

    [AssertionMethod]
    private static void Successful(double expected, object? argument)
    {
        var result = Target(Context.Pattern, argument);

        Assert.Equal(expected, result.GetMatchedArgument());
    }

    [AssertionMethod]
    private static void Unsuccessful(object? argument)
    {
        var result = Target(Context.Pattern, argument);

        Assert.False(result.Successful);
    }
}
