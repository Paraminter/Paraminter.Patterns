namespace Paraminter.Patterns.ArgumentPatternMatchResultFactoryProviderCases;

using Xunit;

public sealed class Successful
{
    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.SuccessfulMock.Object, result);
    }

    private ISuccessfulArgumentPatternMatchResultFactory Target() => Fixture.Sut.Successful;

    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();
}
