namespace Attribinter.Patterns.ArgumentPatternMatchResultCases;

using Moq;

using System;

using Xunit;

public sealed class GetMatchedArgument
{
    private static T Target<T>(ArgumentPatternMatchResult<T> result) => result.GetMatchedArgument();

    [Fact]
    public void Unsuccessful_ThrowsInvalidOperationException()
    {
        var result = ArgumentPatternMatchResult.CreateUnsuccessful<int>();

        var exception = Record.Exception(() => Target(result));

        Assert.IsType<InvalidOperationException>(exception);
    }

    [Fact]
    public void Successful_ReturnsProvidedValue()
    {
        var expected = Mock.Of<object>();

        var result = ArgumentPatternMatchResult.CreateSuccessful(expected);

        var actual = Target(result);

        Assert.Same(expected, actual);
    }

    [Fact]
    public void SuccessfulButNull_ReturnsNull()
    {
        var result = ArgumentPatternMatchResult.CreateSuccessful<object>(null!);

        var actual = Target(result);

        Assert.Null(actual);
    }
}
