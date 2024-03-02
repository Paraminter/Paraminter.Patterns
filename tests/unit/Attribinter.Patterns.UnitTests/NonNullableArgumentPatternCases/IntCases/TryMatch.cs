namespace Attribinter.Patterns.NonNullableArgumentPatternCases.IntCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<int> Target(IArgumentPattern<int> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Int_0_Successful() => Successful(0, 0);

    [Fact]
    public void Int_1_Successful() => Successful(1, 1);

    [Fact]
    public void Int_Negative1_Successful() => Successful(-1, -1);

    [Fact]
    public void Short_Unsuccessful() => Unsuccessful((short)0);

    [Fact]
    public void Long_Unsuccessful() => Unsuccessful((long)0);

    [Fact]
    public void Object_Unsuccessful() => Unsuccessful(Mock.Of<object>());

    [Fact]
    public void Null_Unsuccessful() => Unsuccessful(null);

    [AssertionMethod]
    private static void Successful(int expected, object? argument)
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
