namespace Paraminter.Patterns.SuccessfulArgumentPatternMatchResultFactoryCases;

using Moq;

using Xunit;

public sealed class Create
{
    [Fact]
    public void NullMatchedArgument_ReturnsResult()
    {
        var result = Target<object?>(null);

        Assert.NotNull(result);
    }

    [Fact]
    public void NonNullMatchedArgument_ReturnsResult()
    {
        var result = Target(Mock.Of<object>());

        Assert.NotNull(result);
    }

    private IArgumentPatternMatchResult<TMatchedArgument> Target<TMatchedArgument>(TMatchedArgument matchedArgument) => Fixture.Sut.Create(matchedArgument);

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();
}
