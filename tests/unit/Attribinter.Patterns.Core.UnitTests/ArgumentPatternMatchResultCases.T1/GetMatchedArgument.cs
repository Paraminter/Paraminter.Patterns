namespace Attribinter.Patterns.ArgumentPatternMatchResultCases.T1;

using Moq;

using System;

using Xunit;

public sealed class GetMatchedArgument
{
    [Fact]
    public void Unsuccessful_ThrowsInvalidOperationException()
    {
        var sut = ArgumentPatternMatchResult.CreateUnsuccessful<int>();

        var result = Record.Exception(() => Target(sut));

        Assert.IsType<InvalidOperationException>(result);
    }

    [Fact]
    public void Successful_ReturnsProvidedValue()
    {
        var expected = Mock.Of<object>();

        var sut = ArgumentPatternMatchResult.CreateSuccessful(expected);

        var result = Target(sut);

        Assert.Same(expected, result);
    }

    [Fact]
    public void SuccessfulButNull_ReturnsNull()
    {
        var sut = ArgumentPatternMatchResult.CreateSuccessful<object>(null!);

        var result = Target(sut);

        Assert.Null(result);
    }

    private static T Target<T>(ArgumentPatternMatchResult<T> result) => result.GetMatchedArgument();
}
