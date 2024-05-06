namespace Paraminter.Patterns.SuccessfulArgumentPatternMatchResultFactoryCases.ArgumentPatternMatchResultCases;

using Xunit;

public sealed class GetMatchedArgument
{
    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var fixture = ResultFixtureFactory.Create<object>();

        var result = Target(fixture);

        Assert.Same(fixture.MatchedArgumentMock.Object, result);
    }

    private static TMatchedArgument Target<TMatchedArgument>(IResultFixture<TMatchedArgument> fixture)
        where TMatchedArgument : class
    {
        return fixture.Sut.GetMatchedArgument();
    }
}
