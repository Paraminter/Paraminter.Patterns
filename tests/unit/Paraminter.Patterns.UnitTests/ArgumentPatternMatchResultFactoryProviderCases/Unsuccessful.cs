namespace Paraminter.Patterns.ArgumentPatternMatchResultFactoryProviderCases;

using Xunit;

public sealed class Unsuccessful
{
    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.Same(Fixture.UnsuccessfulMock.Object, result);
    }

    private IUnsuccessfulArgumentPatternMatchResultFactory Target() => Fixture.Sut.Unsuccessful;
}
