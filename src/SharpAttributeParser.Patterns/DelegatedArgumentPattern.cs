namespace SharpAttributeParser.Patterns;

using System;

internal sealed class DelegatedArgumentPattern<T> : IArgumentPattern<T>
{
    private readonly Func<object?, PatternMatchResult<T>> PatternDelegate;

    public DelegatedArgumentPattern(Func<object?, PatternMatchResult<T>> patternDelegate)
    {
        PatternDelegate = patternDelegate;
    }

    PatternMatchResult<T> IArgumentPattern<T>.TryMatch(object? argument) => PatternDelegate(argument);
}
