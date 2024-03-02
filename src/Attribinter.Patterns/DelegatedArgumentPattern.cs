namespace Attribinter.Patterns;

using System;

internal sealed class DelegatedArgumentPattern<T> : IArgumentPattern<T>
{
    private readonly Func<object?, ArgumentPatternMatchResult<T>> PatternDelegate;

    public DelegatedArgumentPattern(Func<object?, ArgumentPatternMatchResult<T>> patternDelegate)
    {
        PatternDelegate = patternDelegate;
    }

    ArgumentPatternMatchResult<T> IArgumentPattern<T>.TryMatch(object? argument) => PatternDelegate(argument);
}
