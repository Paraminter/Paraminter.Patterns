namespace Attribinter.Patterns.NullableReadOnlyArrayArgumentPatternCases;

using Moq;

using System;
using System.Collections.Generic;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<IReadOnlyList<TElement>?> Target<TElement>(IArgumentPattern<IReadOnlyList<TElement>?> pattern, object? argument) => pattern.TryMatch(argument);

    [Fact]
    public void Empty_Successful() => Successful(Mock.Of<IArgumentPattern<object>>(), Array.Empty<object>(), Array.Empty<object>());

    [Fact]
    public void ObjectArray_ResultReturningElementPattern_UsesElementPatternAndSuccessful()
    {
        var inputArgument = Mock.Of<object>();
        var outputArgument = ArgumentPatternMatchResult.CreateSuccessful(string.Empty);

        Mock<IArgumentPattern<string>> elementPatternMock = new();

        elementPatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object?>())).Returns(outputArgument);

        Successful(elementPatternMock.Object, new[] { outputArgument.GetMatchedArgument(), outputArgument.GetMatchedArgument() }, new[] { inputArgument, inputArgument });

        elementPatternMock.Verify((pattern) => pattern.TryMatch(inputArgument), Times.Exactly(2));
    }

    [Fact]
    public void ElementArray_ResultReturningElementPattern_UsesElementPatternAndSuccessful()
    {
        var inputArgument = Mock.Of<object>();
        var outputArgument = ArgumentPatternMatchResult.CreateSuccessful(Mock.Of<object>());

        Mock<IArgumentPattern<object>> elementPatternMock = new();

        elementPatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object?>())).Returns(outputArgument);

        Successful(elementPatternMock.Object, new[] { outputArgument.GetMatchedArgument(), outputArgument.GetMatchedArgument() }, new[] { inputArgument, inputArgument });

        elementPatternMock.Verify((pattern) => pattern.TryMatch(inputArgument), Times.Exactly(2));
    }

    [Fact]
    public void Null_Successful() => Successful(Mock.Of<IArgumentPattern<object>>(), null, null);

    [Fact]
    public void NotArray_Unsuccessful() => Unsuccessful(Mock.Of<IArgumentPattern<object>>(), Mock.Of<object>());

    [Fact]
    public void ObjectArray_ErrorReturningElementPattern_Unsuccessful()
    {
        var outputArgument = ArgumentPatternMatchResult.CreateUnsuccessful<string>();

        Mock<IArgumentPattern<string>> elementPatternMock = new();

        elementPatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object?>())).Returns(outputArgument);

        Unsuccessful(elementPatternMock.Object, new[] { Mock.Of<object>() });
    }

    [Fact]
    public void ElementArray_ErrorReturningElementPattern_Unsuccessful()
    {
        var outputArgument = ArgumentPatternMatchResult.CreateUnsuccessful<object>();

        Mock<IArgumentPattern<object>> elementPatternMock = new();

        elementPatternMock.Setup(static (pattern) => pattern.TryMatch(It.IsAny<object?>())).Returns(outputArgument);

        Unsuccessful(elementPatternMock.Object, new[] { Mock.Of<object>() });
    }

    [AssertionMethod]
    private static void Successful<TElement>(IArgumentPattern<TElement> elementPattern, IList<TElement>? expected, object? argument)
    {
        var context = PatternContext<TElement>.Create(elementPattern);

        var result = Target(context.Pattern, argument);

        Assert.Equal(expected, result.GetMatchedArgument());
    }

    [AssertionMethod]
    private static void Unsuccessful<TElement>(IArgumentPattern<TElement> elementPattern, object? argument)
    {
        var context = PatternContext<TElement>.Create(elementPattern);

        var result = Target(context.Pattern, argument);

        Assert.False(result.Successful);
    }
}
