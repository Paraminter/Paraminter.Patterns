namespace SharpAttributeParser.Patterns;

using OneOf;
using OneOf.Types;

using System;

internal sealed class DelegatedArgumentPattern<T> : IArgumentPattern<T>
{
    private readonly Func<object?, OneOf<Error, T>> PatternDelegate;

    public DelegatedArgumentPattern(Func<object?, OneOf<Error, T>> patternDelegate)
    {
        PatternDelegate = patternDelegate;
    }

    OneOf<Error, T> IArgumentPattern<T>.TryMatch(object? argument) => PatternDelegate(argument);
}
