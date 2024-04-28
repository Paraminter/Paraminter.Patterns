namespace Attribinter.Patterns.ArgumentRecorderFactoryCases.ArgumentRecorderCases;

using Moq;

internal interface IRecorderFixture<TParameter, TIn, TOut>
{
    public abstract IArgumentRecorder<TParameter, TIn> Sut { get; }

    public abstract Mock<IArgumentRecorder<TParameter, TOut>> PatternedRecorderMock { get; }
    public abstract Mock<IArgumentPattern<TIn, TOut>> PatternMock { get; }
}
