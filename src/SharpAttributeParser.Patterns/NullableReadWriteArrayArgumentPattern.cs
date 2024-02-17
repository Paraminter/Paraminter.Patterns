namespace SharpAttributeParser.Patterns;

using System.Collections.Generic;

internal sealed class NullableReadWriteArrayArgumentPattern<TElement> : IArgumentPattern<IList<TElement>?>
{
    private readonly IArgumentPattern<IList<TElement>> NonNullableCollectionPattern;

    public NullableReadWriteArrayArgumentPattern(IArgumentPattern<IList<TElement>> nonNullableCollectionPattern)
    {
        NonNullableCollectionPattern = nonNullableCollectionPattern;
    }

    PatternMatchResult<IList<TElement>?> IArgumentPattern<IList<TElement>?>.TryMatch(object? argument)
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
