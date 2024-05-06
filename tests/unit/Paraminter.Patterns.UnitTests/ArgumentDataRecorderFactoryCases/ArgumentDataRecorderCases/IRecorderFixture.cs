namespace Paraminter.Patterns.ArgumentDataRecorderFactoryCases.ArgumentDataRecorderCases;

using Moq;

internal interface IRecorderFixture<TParameter, TUnpatternedArgumentData, TPatternedArgumentData>
{
    public abstract IArgumentDataRecorder<TParameter, TUnpatternedArgumentData> Sut { get; }

    public abstract Mock<IArgumentDataRecorder<TParameter, TPatternedArgumentData>> PatternedRecorderMock { get; }
    public abstract Mock<IArgumentPattern<TUnpatternedArgumentData, TPatternedArgumentData>> PatternMock { get; }
}
