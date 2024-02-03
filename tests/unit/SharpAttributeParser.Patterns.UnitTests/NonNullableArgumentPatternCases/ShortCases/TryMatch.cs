namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.ShortCases;

using Moq;

using OneOf;
using OneOf.Types;

using Xunit;

public sealed class TryMatch
{
    private static OneOf<Error, short> Target(IArgumentPattern<short> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void Short_0_ResultsInMatch() => ResultsInMatch(0, (short)0);

    [Fact]
    public void Short_1_ResultsInMatch() => ResultsInMatch(1, (short)1);

    [Fact]
    public void Short_Negative1_ResultsInMatch() => ResultsInMatch(-1, (short)-1);

    [Fact]
    public void Byte_ResultsInError() => ResultsInError((byte)0);

    [Fact]
    public void Int_ResultsInError() => ResultsInError(0);

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(short expected, object? argument)
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
