namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.ULongCases;

using Moq;

using OneOf;
using OneOf.Types;

using Xunit;

public sealed class TryMatch
{
    private static OneOf<Error, ulong> Target(IArgumentPattern<ulong> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void ULong_0_ResultsInMatch() => ResultsInMatch(0, (ulong)0);

    [Fact]
    public void ULong_1_ResultsInMatch() => ResultsInMatch(1, (ulong)1);

    [Fact]
    public void UInt_ResultsInError() => ResultsInError((uint)0);

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(ulong expected, object? argument)
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
