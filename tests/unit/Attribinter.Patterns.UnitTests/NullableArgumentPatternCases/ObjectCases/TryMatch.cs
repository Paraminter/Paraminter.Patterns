namespace Attribinter.Patterns.NullableArgumentPatternCases.ObjectCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<object?> Target(IArgumentPattern<object?> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Object_Successful()
    {
        var argument = Mock.Of<object>();

        Successful(argument, argument);
    }

    [Fact]
    public void String_Successful() => Successful(string.Empty, string.Empty);

    [Fact]
    public void Int_Successful() => Successful(0, 0);

    [Fact]
    public void Null_Successful() => Successful(null, null);

    [AssertionMethod]
    private static void Successful(object? expected, object? argument)
    {
        var result = Target(Context.Pattern, argument);

        Assert.Equal(expected, result.GetMatchedArgument());
    }
}
