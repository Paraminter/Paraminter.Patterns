namespace SharpAttributeParser.Patterns.NullableReadOnlyArrayArgumentPatternCases;

using Moq;

using System;
using System.Collections.Generic;

using Xunit;

public sealed class TryMatch
{
    private static PatternMatchResult<IReadOnlyList<TElement>?> Target<TElement>(IArgumentPattern<IReadOnlyList<TElement>?> pattern, object? argument) => pattern.TryMatch(argument);

    [Fact]
    public void Empty_ResultsInMatch() => ResultsInMatch(Mock.Of<IArgumentPattern<object>>(), Array.Empty<object>(), Array.Empty<object>());

    [Fact]
    public void ObjectArray_ResultReturningElementPattern_UsesElementPatternAndResultsInMatch()
    {
        var inputArgument = Mock.Of<object>();
        PatternMatchResult<string> outputArgument = new(string.Empty);

        Mock<IArgumentPattern<string>> elementPatternMock = new();

        elementPatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object?>())).Returns(outputArgument);

        ResultsInMatch(elementPatternMock.Object, new[] { outputArgument.GetMatchedArgument(), outputArgument.GetMatchedArgument() }, new[] { inputArgument, inputArgument });

        elementPatternMock.Verify((pattern) => pattern.TryMatch(inputArgument), Times.Exactly(2));
    }

    [Fact]
    public void ElementArray_ResultReturningElementPattern_UsesElementPatternAndResultsInMatch()
    {
        var inputArgument = Mock.Of<object>();
        PatternMatchResult<object> outputArgument = new(Mock.Of<object>());

        Mock<IArgumentPattern<object>> elementPatternMock = new();

        elementPatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object?>())).Returns(outputArgument);

        ResultsInMatch(elementPatternMock.Object, new[] { outputArgument.GetMatchedArgument(), outputArgument.GetMatchedArgument() }, new[] { inputArgument, inputArgument });

        elementPatternMock.Verify((pattern) => pattern.TryMatch(inputArgument), Times.Exactly(2));
    }

    [Fact]
    public void Null_ResultsInMatch() => ResultsInMatch(Mock.Of<IArgumentPattern<object>>(), null, null);

    [Fact]
    public void NotArray_ResultsInError() => ResultsInError(Mock.Of<IArgumentPattern<object>>(), Mock.Of<object>());

    [Fact]
    public void ObjectArray_ErrorReturningElementPattern_ResultsInError()
    {
        PatternMatchResult<string> outputArgument = new();

        Mock<IArgumentPattern<string>> elementPatternMock = new();

        elementPatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object?>())).Returns(outputArgument);

        ResultsInError(elementPatternMock.Object, new[] { Mock.Of<object>() });
    }

    [Fact]
    public void ElementArray_ErrorReturningElementPattern_ResultsInError()
    {
        PatternMatchResult<object> outputArgument = new();

        Mock<IArgumentPattern<object>> elementPatternMock = new();

        elementPatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object?>())).Returns(outputArgument);

        ResultsInError(elementPatternMock.Object, new[] { Mock.Of<object>() });
    }

    [AssertionMethod]
    private static void ResultsInMatch<TElement>(IArgumentPattern<TElement> elementPattern, IList<TElement>? expected, object? argument)
    {
        var context = PatternContext<TElement>.Create(elementPattern);

        var result = Target(context.Pattern, argument);

        Assert.Equal(expected, result.GetMatchedArgument());
    }

    [AssertionMethod]
    private static void ResultsInError<TElement>(IArgumentPattern<TElement> elementPattern, object? argument)
    {
        var context = PatternContext<TElement>.Create(elementPattern);

        var result = Target(context.Pattern, argument);

        Assert.False(result.WasSuccessful);
    }
}
