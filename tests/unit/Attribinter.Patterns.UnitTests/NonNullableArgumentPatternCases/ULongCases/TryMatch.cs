namespace Attribinter.Patterns.NonNullableArgumentPatternCases.ULongCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<ulong> Target(IArgumentPattern<ulong> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void ULong_0_Successful() => Successful(0, (ulong)0);

    [Fact]
    public void ULong_1_Successful() => Successful(1, (ulong)1);

    [Fact]
    public void UInt_Unsuccessful() => Unsuccessful((uint)0);

    [Fact]
    public void Object_Unsuccessful() => Unsuccessful(Mock.Of<object>());

    [Fact]
    public void Null_Unsuccessful() => Unsuccessful(null);

    [AssertionMethod]
    private static void Successful(ulong expected, object? argument)
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
