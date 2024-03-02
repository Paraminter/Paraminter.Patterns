namespace Attribinter.Patterns;

using System.Collections.Generic;

internal sealed class NullableReadWriteArrayArgumentPattern<TElement> : IArgumentPattern<IList<TElement>?>
{
    private readonly IArgumentPattern<IList<TElement>> NonNullableCollectionPattern;

    public NullableReadWriteArrayArgumentPattern(IArgumentPattern<IList<TElement>> nonNullableCollectionPattern)
    {
        NonNullableCollectionPattern = nonNullableCollectionPattern;
    }

    ArgumentPatternMatchResult<IList<TElement>?> IArgumentPattern<IList<TElement>?>.TryMatch(object? argument)
    {
        if (argument is null)
        {
            return ArgumentPatternMatchResult.CreateSuccessful<IList<TElement>?>(null);
        }

        var nonNullableResult = NonNullableCollectionPattern.TryMatch(argument);

        if (nonNullableResult.Successful is false)
        {
            return ArgumentPatternMatchResult.CreateUnsuccessful<IList<TElement>?>();
        }

        return ArgumentPatternMatchResult.CreateSuccessful<IList<TElement>?>(nonNullableResult.GetMatchedArgument());
    }
}
