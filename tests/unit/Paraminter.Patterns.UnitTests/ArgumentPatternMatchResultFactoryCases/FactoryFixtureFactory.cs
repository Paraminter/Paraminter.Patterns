namespace Paraminter.Patterns.ArgumentPatternMatchResultFactoryCases;

using Moq;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        Mock<IArgumentPatternMatchResultFactoryProvider> factoryProviderMock = new();

        ArgumentPatternMatchResultFactory sut = new(factoryProviderMock.Object);

        return new FactoryFixture(sut, factoryProviderMock);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IArgumentPatternMatchResultFactory Sut;

        private readonly Mock<IArgumentPatternMatchResultFactoryProvider> FactoryProviderMock;

        public FactoryFixture(IArgumentPatternMatchResultFactory sut, Mock<IArgumentPatternMatchResultFactoryProvider> factoryProviderMock)
        {
            Sut = sut;

            FactoryProviderMock = factoryProviderMock;
        }

        IArgumentPatternMatchResultFactory IFactoryFixture.Sut => Sut;

        Mock<IArgumentPatternMatchResultFactoryProvider> IFactoryFixture.FactoryProviderMock => FactoryProviderMock;
    }
}
