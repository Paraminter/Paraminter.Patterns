namespace Paraminter.Patterns.UnsuccessfulArgumentPatternMatchResultFactoryCases;

using Xunit;

public sealed class Create
{
    [Fact]
    public void ReturnsResult()
    {
        var result = Target<object>();

        Assert.NotNull(result);
    }

    private IArgumentPatternMatchResult<TMatchedArgument> Target<TMatchedArgument>() => Fixture.Sut.Create<TMatchedArgument>();

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();
}
