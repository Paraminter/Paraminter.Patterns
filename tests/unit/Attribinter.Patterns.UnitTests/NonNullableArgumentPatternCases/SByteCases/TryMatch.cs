namespace Attribinter.Patterns.NonNullableArgumentPatternCases.SByteCases;

using Moq;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<sbyte> Target(IArgumentPattern<sbyte> pattern, object? argument) => pattern.TryMatch(argument);

    private static readonly PatternContext Context = PatternContext.Create();

    [Fact]
    public void SByte_0_Successful() => Successful(0, (sbyte)0);

    [Fact]
    public void SByte_1_Successful() => Successful(1, (sbyte)1);

    [Fact]
    public void SByte_Negative1_Successful() => Successful(-1, (sbyte)-1);

    [Fact]
    public void Byte_Unsuccessful() => Unsuccessful((byte)0);

    [Fact]
    public void Object_Unsuccessful() => Unsuccessful(Mock.Of<object>());

    [Fact]
    public void Null_Unsuccessful() => Unsuccessful(null);

    [AssertionMethod]
    private static void Successful(sbyte expected, object? argument)
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
