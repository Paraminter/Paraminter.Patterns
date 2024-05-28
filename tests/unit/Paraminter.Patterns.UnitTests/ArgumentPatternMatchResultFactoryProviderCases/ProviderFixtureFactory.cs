namespace Paraminter.Patterns.ArgumentPatternMatchResultFactoryProviderCases;

using Moq;

internal static class ProviderFixtureFactory
{
    public static IProviderFixture Create()
    {
        Mock<ISuccessfulArgumentPatternMatchResultFactory> successfulMock = new();
        Mock<IUnsuccessfulArgumentPatternMatchResultFactory> unsuccessfulMock = new();

        ArgumentPatternMatchResultFactoryProvider sut = new(successfulMock.Object, unsuccessfulMock.Object);

        return new ProviderFixture(sut, successfulMock, unsuccessfulMock);
    }

    private sealed class ProviderFixture
        : IProviderFixture
    {
        private readonly IArgumentPatternMatchResultFactoryProvider Sut;

        private readonly Mock<ISuccessfulArgumentPatternMatchResultFactory> SuccessfulMock;
        private readonly Mock<IUnsuccessfulArgumentPatternMatchResultFactory> UnsuccessfulMock;

        public ProviderFixture(
            IArgumentPatternMatchResultFactoryProvider sut,
            Mock<ISuccessfulArgumentPatternMatchResultFactory> factoryProviderMock,
            Mock<IUnsuccessfulArgumentPatternMatchResultFactory> unsuccessfulMock)
        {
            Sut = sut;

            SuccessfulMock = factoryProviderMock;
            UnsuccessfulMock = unsuccessfulMock;
        }

        IArgumentPatternMatchResultFactoryProvider IProviderFixture.Sut => Sut;

        Mock<ISuccessfulArgumentPatternMatchResultFactory> IProviderFixture.SuccessfulMock => SuccessfulMock;
        Mock<IUnsuccessfulArgumentPatternMatchResultFactory> IProviderFixture.UnsuccessfulMock => UnsuccessfulMock;
    }
}
