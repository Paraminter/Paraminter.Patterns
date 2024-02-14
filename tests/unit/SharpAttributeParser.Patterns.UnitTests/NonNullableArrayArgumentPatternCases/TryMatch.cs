namespace SharpAttributeParser.Patterns.NonNullableArrayArgumentPatternCases;

using Moq;

using OneOf;
using OneOf.Types;

using System;
using System.Collections.Generic;

using Xunit;

public sealed class TryMatch
{
    private static OneOf<Error, IList<TElement>> Target<TElement>(IArgumentPattern<IList<TElement>> pattern, object? argument) => pattern.TryMatch(argument);

    [Fact]
    public void Empty_ResultsInMatch() => ResultsInMatch(Mock.Of<IArgumentPattern<object>>(), Array.Empty<object>(), Array.Empty<object>());

    [Fact]
    public void ResultReturningElementPattern_UsesElementPatternAndResultsInMatch()
    {
        var inputArgument = Mock.Of<object>();
        var outputArgument = Mock.Of<object>();

        Mock<IArgumentPattern<object>> elementPatternMock = new();

        elementPatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object?>())).Returns(outputArgument);

        ResultsInMatch(elementPatternMock.Object, new[] { outputArgument, outputArgument }, new[] { inputArgument, inputArgument });

        elementPatternMock.Verify((pattern) => pattern.TryMatch(inputArgument), Times.Exactly(2));
    }

    [Fact]
    public void Null_ResultsInError() => ResultsInError(Mock.Of<IArgumentPattern<object>>(), null);

    [Fact]
    public void ErrorReturningElementPattern_ResultsInError()
    {
        Mock<IArgumentPattern<object>> elementPatternMock = new();

        elementPatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object?>())).Returns(new Error());

        ResultsInError(elementPatternMock.Object, new[] { Mock.Of<object>() });
    }

    [AssertionMethod]
    private static void ResultsInMatch<TElement>(IArgumentPattern<TElement> elementPattern, IList<TElement> expected, object? argument)
    {
        var context = PatternContext<TElement>.Create(elementPattern);

        var result = Target(context.Pattern, argument);

        Assert.Equal(expected, result.AsT1);
    }

    [AssertionMethod]
    private static void ResultsInError<TElement>(IArgumentPattern<TElement> elementPattern, object? argument)
    {
        var context = PatternContext<TElement>.Create(elementPattern);

        var result = Target(context.Pattern, argument);

        Assert.Equal(new Error(), result);
    }
}
