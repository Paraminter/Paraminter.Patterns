namespace Paraminter.Patterns.UnsuccessfulArgumentPatternMatchResultFactoryCases.ArgumentPatternMatchResultCases;

using System;

using Xunit;

public sealed class GetMatchedArgument
{
    [Fact]
    public void ThrowsInvalidOperationException()
    {
        var fixture = ResultFixtureFactory.Create<object>();

        var result = Record.Exception(() => Target(fixture));

        Assert.IsType<InvalidOperationException>(result);
    }

    private static TMatchedArgument Target<TMatchedArgument>(IResultFixture<TMatchedArgument> fixture) => fixture.Sut.GetMatchedArgument();
}
