namespace Attribinter.Patterns.NonNullableArgumentPatternCases.ShortCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<short> Target(IArgumentPattern<short> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Short_0_Successful() => Successful(0, (short)0);

    [Fact]
    public void Short_1_Successful() => Successful(1, (short)1);

    [Fact]
    public void Short_Negative1_Successful() => Successful(-1, (short)-1);

    [Fact]
    public void Byte_Unsuccessful() => Unsuccessful((byte)0);

    [Fact]
    public void Int_Unsuccessful() => Unsuccessful(0);

    [Fact]
    public void Object_Unsuccessful() => Unsuccessful(Mock.Of<object>());

    [Fact]
    public void Null_Unsuccessful() => Unsuccessful(null);

    [AssertionMethod]
    private static void Successful(short expected, object? argument)
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
