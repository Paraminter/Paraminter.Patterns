namespace Attribinter.Patterns.NonNullableArgumentPatternCases.UIntCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<uint> Target(IArgumentPattern<uint> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void UInt_0_Successful() => Successful(0, (uint)0);

    [Fact]
    public void UInt_1_Successful() => Successful(1, (uint)1);

    [Fact]
    public void UShort_Unsuccessful() => Unsuccessful((ushort)0);

    [Fact]
    public void ULong_Unsuccessful() => Unsuccessful((ulong)0);

    [Fact]
    public void Object_Unsuccessful() => Unsuccessful(Mock.Of<object>());

    [Fact]
    public void Null_Unsuccessful() => Unsuccessful(null);

    [AssertionMethod]
    private static void Successful(uint expected, object? argument)
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
