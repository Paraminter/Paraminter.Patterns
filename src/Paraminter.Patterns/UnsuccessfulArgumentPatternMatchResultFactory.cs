namespace Paraminter.Patterns;

using System;

/// <inheritdoc cref="IUnsuccessfulArgumentPatternMatchResultFactory"/>
public sealed class UnsuccessfulArgumentPatternMatchResultFactory
    : IUnsuccessfulArgumentPatternMatchResultFactory
{
    /// <summary>Instantiates a <see cref="UnsuccessfulArgumentPatternMatchResultFactory"/>, handling creation of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing unsuccessful attempts to match arguments to patterns.</summary>
    public UnsuccessfulArgumentPatternMatchResultFactory() { }

    IArgumentPatternMatchResult<TMatchedArgument> IUnsuccessfulArgumentPatternMatchResultFactory.Create<TMatchedArgument>() => new ArgumentPatternMatchResult<TMatchedArgument>();

    private sealed class ArgumentPatternMatchResult<TMatchedArgument>
        : IArgumentPatternMatchResult<TMatchedArgument>
    {
        bool IArgumentPatternMatchResult<TMatchedArgument>.WasSuccessful => false;

        TMatchedArgument IArgumentPatternMatchResult<TMatchedArgument>.GetMatchedArgument() => throw new InvalidOperationException("Cannot retrieve the matched argument, as the attempt to match an argument was unsuccessful.");
    }
}
