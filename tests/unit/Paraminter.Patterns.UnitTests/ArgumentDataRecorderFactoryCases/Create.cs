namespace Paraminter.Patterns.ArgumentDataRecorderFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Create
{
    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void NullPatternedRecorder_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target<object, object, object>(null!, Mock.Of<IArgumentPattern<object, object>>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullPattern_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target<object, object, object>(Mock.Of<IArgumentDataRecorder<object, object>>(), null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidArguments_ReturnsRecorder()
    {
        var result = Target(Mock.Of<IArgumentDataRecorder<object, object>>(), Mock.Of<IArgumentPattern<object, object>>());

        Assert.NotNull(result);
    }

    private IArgumentDataRecorder<TParameter, TUnpatternedArgumentData> Target<TParameter, TUnpatternedArgumentData, TPatternedArgumentData>(
        IArgumentDataRecorder<TParameter, TPatternedArgumentData> patternedRecorder,
        IArgumentPattern<TUnpatternedArgumentData, TPatternedArgumentData> pattern)
    {
        return Fixture.Sut.Create(patternedRecorder, pattern);
    }
}
