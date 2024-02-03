namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.UShortCases;

using Moq;

using OneOf;
using OneOf.Types;

using Xunit;

public sealed class TryMatch
{
    private static OneOf<Error, ushort> Target(IArgumentPattern<ushort> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void UShort_0_ResultsInMatch() => ResultsInMatch(0, (ushort)0);

    [Fact]
    public void UShort_1_ResultsInMatch() => ResultsInMatch(1, (ushort)1);

    [Fact]
    public void Byte_ResultsInError() => ResultsInError((byte)0);

    [Fact]
    public void Int_ResultsInError() => ResultsInError(0);

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(ushort expected, object? argument)
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
