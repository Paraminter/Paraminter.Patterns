namespace Paraminter.Patterns.ArgumentDataRecorderFactoryCases.ArgumentDataRecorderCases;

using Moq;

internal static class RecorderFixtureFactory<TParameter, TUnpatternedArgumentData, TPatternedArgumentData>
{
    public static IRecorderFixture<TParameter, TUnpatternedArgumentData, TPatternedArgumentData> Create()
    {
        Mock<IArgumentDataRecorder<TParameter, TPatternedArgumentData>> patternedRecorderMock = new();
        Mock<IArgumentPattern<TUnpatternedArgumentData, TPatternedArgumentData>> patternMock = new();

        IArgumentDataRecorderFactory factory = new ArgumentDataRecorderFactory();

        var sut = factory.Create(patternedRecorderMock.Object, patternMock.Object);

        return new RecorderFixture(sut, patternedRecorderMock, patternMock);
    }

    private sealed class RecorderFixture
        : IRecorderFixture<TParameter, TUnpatternedArgumentData, TPatternedArgumentData>
    {
        private readonly IArgumentDataRecorder<TParameter, TUnpatternedArgumentData> Sut;

        private readonly Mock<IArgumentDataRecorder<TParameter, TPatternedArgumentData>> PatternedRecorderMock;
        private readonly Mock<IArgumentPattern<TUnpatternedArgumentData, TPatternedArgumentData>> PatternMock;

        public RecorderFixture(
            IArgumentDataRecorder<TParameter, TUnpatternedArgumentData> sut,
            Mock<IArgumentDataRecorder<TParameter, TPatternedArgumentData>> patternedRecorderMock,
            Mock<IArgumentPattern<TUnpatternedArgumentData, TPatternedArgumentData>> patternMock)
        {
            Sut = sut;

            PatternedRecorderMock = patternedRecorderMock;
            PatternMock = patternMock;
        }

        IArgumentDataRecorder<TParameter, TUnpatternedArgumentData> IRecorderFixture<TParameter, TUnpatternedArgumentData, TPatternedArgumentData>.Sut => Sut;

        Mock<IArgumentDataRecorder<TParameter, TPatternedArgumentData>> IRecorderFixture<TParameter, TUnpatternedArgumentData, TPatternedArgumentData>.PatternedRecorderMock => PatternedRecorderMock;
        Mock<IArgumentPattern<TUnpatternedArgumentData, TPatternedArgumentData>> IRecorderFixture<TParameter, TUnpatternedArgumentData, TPatternedArgumentData>.PatternMock => PatternMock;
    }
}
