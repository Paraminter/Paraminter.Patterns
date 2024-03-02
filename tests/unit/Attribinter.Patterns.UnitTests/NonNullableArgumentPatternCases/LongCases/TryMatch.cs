namespace Attribinter.Patterns.NonNullableArgumentPatternCases.LongCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<long> Target(IArgumentPattern<long> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Long_0_Successful() => Successful(0, (long)0);

    [Fact]
    public void Long_1_Successful() => Successful(1, (long)1);

    [Fact]
    public void Long_Negative1_Successful() => Successful(-1, (long)-1);

    [Fact]
    public void Int_Unsuccessful() => Unsuccessful(0);

    [Fact]
    public void Object_Unsuccessful() => Unsuccessful(Mock.Of<object>());

    [Fact]
    public void Null_Unsuccessful() => Unsuccessful(null);

    [AssertionMethod]
    private static void Successful(long expected, object? argument)
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
