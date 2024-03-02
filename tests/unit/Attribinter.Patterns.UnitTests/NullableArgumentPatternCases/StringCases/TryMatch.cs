namespace Attribinter.Patterns.NullableArgumentPatternCases.StringCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<string?> Target(IArgumentPattern<string?> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void String_Empty_Successful() => Successful(string.Empty, string.Empty);

    [Fact]
    public void String_NonEmpty_Successful() => Successful("A", "A");

    [Fact]
    public void Object_Unsuccessful() => Unsuccessful(Mock.Of<object>());

    [Fact]
    public void Int_Unsuccessful() => Unsuccessful(0);

    [Fact]
    public void Null_Successful() => Successful(null, null);

    [AssertionMethod]
    private static void Successful(string? expected, object? argument)
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
