namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.UIntCases;

using Moq;

using OneOf;
using OneOf.Types;

using Xunit;

public sealed class TryMatch
{
    private static OneOf<Error, uint> Target(IArgumentPattern<uint> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void UInt_0_ResultsInMatch() => ResultsInMatch(0, (uint)0);

    [Fact]
    public void UInt_1_ResultsInMatch() => ResultsInMatch(1, (uint)1);

    [Fact]
    public void UShort_ResultsInError() => ResultsInError((ushort)0);

    [Fact]
    public void ULong_ResultsInError() => ResultsInError((ulong)0);

    [Fact]
    public void Object_ResultsInError() => ResultsInError(Mock.Of<object>());

    [Fact]
    public void Null_ResultsInError() => ResultsInError(null);

    [AssertionMethod]
    private static void ResultsInMatch(uint expected, object? argument)
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
