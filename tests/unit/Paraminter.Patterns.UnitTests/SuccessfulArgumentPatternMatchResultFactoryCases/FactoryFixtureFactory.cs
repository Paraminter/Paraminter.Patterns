namespace Paraminter.Patterns.SuccessfulArgumentPatternMatchResultFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        SuccessfulArgumentPatternMatchResultFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture
        : IFactoryFixture
    {
        private readonly ISuccessfulArgumentPatternMatchResultFactory Sut;

        public FactoryFixture(
            ISuccessfulArgumentPatternMatchResultFactory sut)
        {
            Sut = sut;
        }

        ISuccessfulArgumentPatternMatchResultFactory IFactoryFixture.Sut => Sut;
    }
}
