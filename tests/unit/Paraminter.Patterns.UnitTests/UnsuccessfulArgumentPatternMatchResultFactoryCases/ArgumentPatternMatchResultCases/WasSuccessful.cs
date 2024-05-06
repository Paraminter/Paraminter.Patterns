namespace Paraminter.Patterns.UnsuccessfulArgumentPatternMatchResultFactoryCases.ArgumentPatternMatchResultCases;

using Xunit;

public sealed class WasSuccessful
{
    [Fact]
    public void ReturnsFalse()
    {
        var fixture = ResultFixtureFactory.Create<object>();

        var result = Target(fixture);

        Assert.False(result);
    }

    private static bool Target<TMatchedArgument>(IResultFixture<TMatchedArgument> fixture) => fixture.Sut.WasSuccessful;
}
