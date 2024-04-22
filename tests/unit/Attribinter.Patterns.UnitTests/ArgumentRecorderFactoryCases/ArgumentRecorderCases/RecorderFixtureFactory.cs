namespace Attribinter.Patterns.ArgumentRecorderFactoryCases.ArgumentRecorderCases;

using Moq;

internal static class RecorderFixtureFactory<TParameter, TIn, TOut>
{
    public static IRecorderFixture<TParameter, TIn, TOut> Create()
    {
        Mock<IArgumentRecorder<TParameter, TOut>> patternedRecorderMock = new();
        Mock<IArgumentPattern<TIn, TOut>> patternMock = new();

        IArgumentRecorderFactory factory = new ArgumentRecorderFactory();

        var sut = factory.Create(patternedRecorderMock.Object, patternMock.Object);

        return new RecorderFixture(sut, patternedRecorderMock, patternMock);
    }

    private sealed class RecorderFixture : IRecorderFixture<TParameter, TIn, TOut>
    {
        private readonly IArgumentRecorder<TParameter, TIn> Sut;

        private readonly Mock<IArgumentRecorder<TParameter, TOut>> PatternedRecorderMock;
        private readonly Mock<IArgumentPattern<TIn, TOut>> PatternMock;

        public RecorderFixture(IArgumentRecorder<TParameter, TIn> sut, Mock<IArgumentRecorder<TParameter, TOut>> patternedRecorderMock, Mock<IArgumentPattern<TIn, TOut>> patternMock)
        {
            Sut = sut;

            PatternedRecorderMock = patternedRecorderMock;
            PatternMock = patternMock;
        }

        IArgumentRecorder<TParameter, TIn> IRecorderFixture<TParameter, TIn, TOut>.Sut => Sut;

        Mock<IArgumentRecorder<TParameter, TOut>> IRecorderFixture<TParameter, TIn, TOut>.PatternedRecorderMock => PatternedRecorderMock;
        Mock<IArgumentPattern<TIn, TOut>> IRecorderFixture<TParameter, TIn, TOut>.PatternMock => PatternMock;
    }
}
