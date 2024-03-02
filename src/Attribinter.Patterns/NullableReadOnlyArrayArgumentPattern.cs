namespace Attribinter.Patterns;

using System.Collections.Generic;

internal sealed class NullableReadOnlyArrayArgumentPattern<TElement> : IArgumentPattern<IReadOnlyList<TElement>?>
{
    private readonly IArgumentPattern<IReadOnlyList<TElement>> NonNullableCollectionPattern;

    public NullableReadOnlyArrayArgumentPattern(IArgumentPattern<IReadOnlyList<TElement>> nonNullableCollectionPattern)
    {
        NonNullableCollectionPattern = nonNullableCollectionPattern;
    }

    ArgumentPatternMatchResult<IReadOnlyList<TElement>?> IArgumentPattern<IReadOnlyList<TElement>?>.TryMatch(object? argument)
    {
        if (argument is null)
        {
            return ArgumentPatternMatchResult.CreateSuccessful<IReadOnlyList<TElement>?>(null);
        }

        var nonNullableResult = NonNullableCollectionPattern.TryMatch(argument);

        if (nonNullableResult.Successful is false)
        {
            return ArgumentPatternMatchResult.CreateUnsuccessful<IReadOnlyList<TElement>?>();
        }

        return ArgumentPatternMatchResult.CreateSuccessful<IReadOnlyList<TElement>?>(nonNullableResult.GetMatchedArgument());
    }
}
