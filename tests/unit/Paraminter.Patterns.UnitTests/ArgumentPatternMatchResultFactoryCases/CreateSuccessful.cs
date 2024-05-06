namespace Paraminter.Patterns.ArgumentPatternMatchResultFactoryCases;

using Moq;

using Xunit;

public sealed class CreateSuccessful
{
    [Fact]
    public void NullMatchedArgument_ReturnsResult()
    {
        object? matchedArgument = null;

        Mock<IArgumentPatternMatchResult<object>> resultMock = new();

        Fixture.FactoryProviderMock.Setup((provider) => provider.Successful.Create(matchedArgument)).Returns(resultMock.Object);

        var result = Target(matchedArgument);

        Assert.Same(resultMock.Object, result);
    }

    [Fact]
    public void NonNullMatchedArgument_ReturnsResult()
    {
        var matchedArgument = Mock.Of<object>();

        Mock<IArgumentPatternMatchResult<object>> resultMock = new();

        Fixture.FactoryProviderMock.Setup((provider) => provider.Successful.Create(matchedArgument)).Returns(resultMock.Object);

        var result = Target(matchedArgument);

        Assert.Same(resultMock.Object, result);
    }

    private IArgumentPatternMatchResult<TMatchedArgument> Target<TMatchedArgument>(TMatchedArgument matchedArgument) => Fixture.Sut.CreateSuccessful(matchedArgument);

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();
}
