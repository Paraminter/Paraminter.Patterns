namespace SharpAttributeParser.Patterns;

using System.Collections.Generic;

internal sealed class NullableReadOnlyArrayArgumentPattern<TElement> : IArgumentPattern<IReadOnlyList<TElement>?>
{
    private readonly IArgumentPattern<IReadOnlyList<TElement>> NonNullableCollectionPattern;

    public NullableReadOnlyArrayArgumentPattern(IArgumentPattern<IReadOnlyList<TElement>> nonNullableCollectionPattern)
    {
        NonNullableCollectionPattern = nonNullableCollectionPattern;
    }

    PatternMatchResult<IReadOnlyList<TElement>?> IArgumentPattern<IReadOnlyList<TElement>?>.TryMatch(object? argument)
    {
        if (argument is null)
        {
            return new(null);
        }

        var nonNullableResult = NonNullableCollectionPattern.TryMatch(argument);

        if (nonNullableResult.WasSuccessful is false)
        {
            return new();
        }

        return new(nonNullableResult.GetMatchedArgument());
    }
}
