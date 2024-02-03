namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.StringCases;

using Moq;

using OneOf;
using OneOf.Types;

using Xunit;

public sealed class TryMatch
{
    private static OneOf<Error, string> Target(IArgumentPattern<string> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void String_Empty_ResultsInMatch() => ResultsInMatch(string.Empty, string.Empty);

    [Fact]
    public void String_NonEmpty_ResultsInMatch() => ResultsInMatch("A", "A");

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Int_ResultsInError() => ResultsInError(0);

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(string expected, object? argument)
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
