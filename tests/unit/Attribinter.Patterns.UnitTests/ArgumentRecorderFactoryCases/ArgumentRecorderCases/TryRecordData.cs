namespace Attribinter.Patterns.ArgumentRecorderFactoryCases.ArgumentRecorderCases;

using Moq;

using System;

using Xunit;

public sealed class TryRecordData
{
    private static bool Target<TParameter, TIn, TOut>(IRecorderFixture<TParameter, TIn, TOut> fixture, TParameter parameter, TIn data) => fixture.Sut.TryRecordData(parameter, data);

    [Fact]
    public void NullParameter_ThrowsArgumentNullException()
    {
        var fixture = RecorderFixtureFactory<object, object, object>.Create();

        var result = Record.Exception(() => Target(fixture, null!, Mock.Of<object>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullData_ThrowsArgumentNullException()
    {
        var fixture = RecorderFixtureFactory<object, object, object>.Create();

        var result = Record.Exception(() => Target(fixture, Mock.Of<object>(), null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NotMatchingPattern_ReturnsFalse()
    {
        var data = Mock.Of<object>();

        var fixture = RecorderFixtureFactory<object, object, object>.Create();

        fixture.PatternMock.Setup((pattern) => pattern.TryMatch(data)).Returns(ArgumentPatternMatchResult.CreateUnsuccessful<object>());

        var result = Target(fixture, Mock.Of<object>(), data);

        Assert.False(result);
    }

    [Fact]
    public void MatchingPattern_ReturnsTrueAndUsesRecorder()
    {
        var parameter = Mock.Of<object>();

        var patternedData = Mock.Of<object>();
        var unpatternedData = Mock.Of<object>();

        var fixture = RecorderFixtureFactory<object, object, object>.Create();

        fixture.PatternMock.Setup((pattern) => pattern.TryMatch(unpatternedData)).Returns(ArgumentPatternMatchResult.CreateSuccessful(patternedData));
        fixture.PatternedRecorderMock.Setup((recorder) => recorder.TryRecordData(parameter, patternedData)).Returns(true);

        var result = Target(fixture, parameter, unpatternedData);

        Assert.True(result);
    }
}
