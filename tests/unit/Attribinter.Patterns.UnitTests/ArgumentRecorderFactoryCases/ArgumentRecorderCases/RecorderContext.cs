namespace Attribinter.Patterns.ArgumentRecorderFactoryCases.ArgumentRecorderCases;

using Moq;

internal sealed class RecorderContext<TParameter, TIn, TOut>
{
    public static RecorderContext<TParameter, TIn, TOut> Create()
    {
        Mock<IArgumentRecorder<TParameter, TOut>> patternedRecorderMock = new();
        Mock<IArgumentPattern<TIn, TOut>> patternMock = new();

        IArgumentRecorderFactory factory = new ArgumentRecorderFactory();

        var recorder = factory.Create(patternedRecorderMock.Object, patternMock.Object);

        return new(recorder, patternedRecorderMock, patternMock);
    }

    public IArgumentRecorder<TParameter, TIn> Recorder { get; }

    public Mock<IArgumentRecorder<TParameter, TOut>> PatternedRecorderMock { get; }
    public Mock<IArgumentPattern<TIn, TOut>> PatternMock { get; }

    private RecorderContext(IArgumentRecorder<TParameter, TIn> recorder, Mock<IArgumentRecorder<TParameter, TOut>> patternedRecorderMock, Mock<IArgumentPattern<TIn, TOut>> patternMock)
    {
        Recorder = recorder;

        PatternedRecorderMock = patternedRecorderMock;
        PatternMock = patternMock;
    }
}
