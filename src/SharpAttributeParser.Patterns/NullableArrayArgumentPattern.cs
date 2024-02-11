namespace SharpAttributeParser.Patterns;

using OneOf;
using OneOf.Types;

using System.Collections.Generic;

internal sealed class NullableArrayArgumentPattern<TElement> : IArgumentPattern<IList<TElement>?>
{
    private readonly IArgumentPattern<IList<TElement>> NonNullableCollectionPattern;

    public NullableArrayArgumentPattern(IArgumentPattern<IList<TElement>> nonNullableCollectionPattern)
    {
        NonNullableCollectionPattern = nonNullableCollectionPattern;
    }

    OneOf<Error, IList<TElement>?> IArgumentPattern<IList<TElement>?>.TryMatch(object? argument)
    {
        if (argument is null)
        {
            return OneOf<Error, IList<TElement>?>.FromT1(null);
        }

        return NonNullableCollectionPattern.TryMatch(argument).Match
        (
            static (error) => error,
            OneOf<Error, IList<TElement>?>.FromT1
        );
    }
}
