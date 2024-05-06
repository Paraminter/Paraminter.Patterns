namespace Paraminter.Patterns.ArgumentPatternMatchResultFactoryCases;

using Moq;

using Xunit;

public sealed class CreateUnsuccessful
{
    [Fact]
    public void ReturnsResult()
    {
        Mock<IArgumentPatternMatchResult<object>> resultMock = new();

        Fixture.FactoryProviderMock.Setup((provider) => provider.Unsuccessful.Create<object>()).Returns(resultMock.Object);

        var result = Target<object>();

        Assert.Same(resultMock.Object, result);
    }

    private IArgumentPatternMatchResult<TMatchedArgument> Target<TMatchedArgument>() => Fixture.Sut.CreateUnsuccessful<TMatchedArgument>();

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();
}
