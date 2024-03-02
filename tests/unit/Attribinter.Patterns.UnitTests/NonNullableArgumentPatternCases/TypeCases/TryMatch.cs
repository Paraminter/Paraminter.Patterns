namespace Attribinter.Patterns.NonNullableArgumentPatternCases.TypeCases;

using Microsoft.CodeAnalysis;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<ITypeSymbol> Target(IArgumentPattern<ITypeSymbol> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Type_Successful()
    {
        var argument = Mock.Of<ITypeSymbol>();

        Successful(argument, argument);
    }

    [Fact]
    public void Object_Unsuccessful() => Unsuccessful(Mock.Of<object>());

    [Fact]
    public void Null_Unsuccessful() => Unsuccessful(null);

    [AssertionMethod]
    private static void Successful(ITypeSymbol expected, object? argument)
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
