namespace Paraminter.Patterns.UnsuccessfulArgumentPatternMatchResultFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        UnsuccessfulArgumentPatternMatchResultFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IUnsuccessfulArgumentPatternMatchResultFactory Sut;

        public FactoryFixture(IUnsuccessfulArgumentPatternMatchResultFactory sut)
        {
            Sut = sut;
        }

        IUnsuccessfulArgumentPatternMatchResultFactory IFactoryFixture.Sut => Sut;
    }
}
