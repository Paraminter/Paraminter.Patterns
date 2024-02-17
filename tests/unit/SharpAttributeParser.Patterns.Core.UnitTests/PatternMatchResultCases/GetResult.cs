namespace SharpAttributeParser.Patterns.PatternMatchResultCases;

using Moq;

using System;

using Xunit;

public sealed class GetResult
{
    private static T Target<T>(PatternMatchResult<T> result) => result.GetMatchedArgument();

    [Fact]
    public void Unsuccessful_InvalidOperationException()
    {
        var result = new PatternMatchResult<int>();

        var exception = Record.Exception(() => Target(result));

        Assert.IsType<InvalidOperationException>(exception);
    }

    [Fact]
    public void Successful_ReturnsProvidedValue()
    {
        var expected = Mock.Of<object>();

        var result = new PatternMatchResult<object>(expected);

        var actual = Target(result);

        Assert.Same(expected, actual);
    }

    [Fact]
    public void SuccessfulButNull_ReturnsNull()
    {
        var result = new PatternMatchResult<object>(null!);

        var actual = Target(result);

        Assert.Null(actual);
    }
}
