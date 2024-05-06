namespace Paraminter.Patterns.ArgumentPatternMatchResultFactoryProviderCases;

using Xunit;

public sealed class Unsuccessful
{
    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.UnsuccessfulMock.Object, result);
    }

    private IUnsuccessfulArgumentPatternMatchResultFactory Target() => Fixture.Sut.Unsuccessful;

    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();
}
