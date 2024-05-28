namespace Paraminter.Patterns.SuccessfulArgumentPatternMatchResultFactoryCases.ArgumentPatternMatchResultCases;

using Xunit;

public sealed class WasSuccessful
{
    [Fact]
    public void ReturnsTrue()
    {
        var fixture = ResultFixtureFactory.Create<object>();

        var result = Target(fixture);

        Assert.True(result);
    }

    private static bool Target<TMatchedArgument>(
        IResultFixture<TMatchedArgument> fixture)
        where TMatchedArgument : class
    {
        return fixture.Sut.WasSuccessful;
    }
}
