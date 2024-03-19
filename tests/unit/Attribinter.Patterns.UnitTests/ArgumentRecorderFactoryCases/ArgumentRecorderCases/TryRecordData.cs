namespace Attribinter.Patterns.ArgumentRecorderFactoryCases.ArgumentRecorderCases;

using Moq;

using System;

using Xunit;

public sealed class TryRecordData
{
    private static bool Target<TParameter, TIn>(IArgumentRecorder<TParameter, TIn> recorder, TParameter parameter, TIn data) => recorder.TryRecordData(parameter, data);

    [Fact]
    public void NullParameter_ThrowsArgumentNullException()
    {
        var context = RecorderContext<object, object, object>.Create();

        var exception = Record.Exception(() => Target(context.Recorder, null!, Mock.Of<object>()));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void NullData_ThrowsArgumentNullException()
    {
        var context = RecorderContext<object, object, object>.Create();

        var exception = Record.Exception(() => Target(context.Recorder, Mock.Of<object>(), null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void NotMatchingPattern_ReturnsFalse()
    {
        var data = Mock.Of<object>();

        var context = RecorderContext<object, object, object>.Create();

        context.PatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object>())).Returns(ArgumentPatternMatchResult.CreateUnsuccessful<object>());

        var actual = Target(context.Recorder, Mock.Of<object>(), data);

        Assert.False(actual);

        context.PatternMock.Verify((pattern) => pattern.TryMatch(data), Times.Once());
        context.PatternMock.VerifyNoOtherCalls();

        context.PatternedRecorderMock.VerifyNoOtherCalls();
    }

    [Fact]
    public void MatchingPattern_ReturnsTrueAndUsesRecorder()
    {
        var parameter = Mock.Of<object>();

        var patternedData = Mock.Of<object>();
        var unpatternedData = Mock.Of<object>();

        var context = RecorderContext<object, object, object>.Create();

        context.PatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object>())).Returns(ArgumentPatternMatchResult.CreateSuccessful(patternedData));
        context.PatternedRecorderMock.Setup(static (recorder) => recorder.TryRecordData(It.IsAny<object>(), It.IsAny<object>())).Returns(true);

        var actual = Target(context.Recorder, parameter, unpatternedData);

        Assert.True(actual);

        context.PatternMock.Verify((pattern) => pattern.TryMatch(unpatternedData), Times.Once());
        context.PatternMock.VerifyNoOtherCalls();

        context.PatternedRecorderMock.Verify((recorder) => recorder.TryRecordData(parameter, patternedData));
        context.PatternedRecorderMock.VerifyNoOtherCalls();
    }
}
