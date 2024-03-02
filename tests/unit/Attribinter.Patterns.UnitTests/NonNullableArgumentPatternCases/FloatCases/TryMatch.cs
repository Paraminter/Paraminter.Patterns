namespace Attribinter.Patterns.NonNullableArgumentPatternCases.FloatCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<float> Target(IArgumentPattern<float> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Float_0_Successful() => Successful(0, 0f);

    [Fact]
    public void Float_Pi_Successful() => Successful(3.14f, 3.14f);

    [Fact]
    public void Float_NegativeE_Successful() => Successful(-2.718f, -2.718f);

    [Fact]
    public void Int_Unsuccessful() => Unsuccessful(0);

    [Fact]
    public void Double_Unsuccessful() => Unsuccessful(0d);

    [Fact]
    public void Object_Unsuccessful() => Unsuccessful(Mock.Of<object>());

    [Fact]
    public void Null_Unsuccessful() => Unsuccessful(null);

    [AssertionMethod]
    private static void Successful(float expected, object? argument)
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
