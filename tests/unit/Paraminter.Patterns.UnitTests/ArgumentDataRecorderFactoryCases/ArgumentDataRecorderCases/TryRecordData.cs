namespace Paraminter.Patterns.ArgumentDataRecorderFactoryCases.ArgumentDataRecorderCases;

using Moq;

using System;

using Xunit;

public sealed class TryRecordData
{
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

        Mock<IArgumentPatternMatchResult<object>> matchResultMock = new();

        var fixture = RecorderFixtureFactory<object, object, object>.Create();

        matchResultMock.Setup(static (result) => result.WasSuccessful).Returns(false);

        fixture.PatternMock.Setup((pattern) => pattern.TryMatch(data)).Returns(matchResultMock.Object);

        var result = Target(fixture, Mock.Of<object>(), data);

        Assert.False(result);

        fixture.PatternedRecorderMock.VerifyNoOtherCalls();
    }

    [Fact]
    public void MatchingPattern_ReturnsTrue()
    {
        var parameter = Mock.Of<object>();

        var patternedData = Mock.Of<object>();
        var unpatternedData = Mock.Of<object>();

        Mock<IArgumentPatternMatchResult<object>> matchResultMock = new();

        var fixture = RecorderFixtureFactory<object, object, object>.Create();

        matchResultMock.Setup(static (result) => result.WasSuccessful).Returns(true);
        matchResultMock.Setup(static (result) => result.GetMatchedArgument()).Returns(patternedData);

        fixture.PatternMock.Setup((pattern) => pattern.TryMatch(unpatternedData)).Returns(matchResultMock.Object);
        fixture.PatternedRecorderMock.Setup((recorder) => recorder.TryRecordData(parameter, patternedData)).Returns(true);

        var result = Target(fixture, parameter, unpatternedData);

        Assert.True(result);

        fixture.PatternedRecorderMock.Verify((recorder) => recorder.TryRecordData(parameter, patternedData), Times.Once());

        fixture.PatternedRecorderMock.VerifyNoOtherCalls();
    }

    private static bool Target<TParameter, TIn, TOut>(IRecorderFixture<TParameter, TIn, TOut> fixture, TParameter parameter, TIn data) => fixture.Sut.TryRecordData(parameter, data);
}
