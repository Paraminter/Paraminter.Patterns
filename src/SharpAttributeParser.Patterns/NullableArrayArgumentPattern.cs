namespace SharpAttributeParser.Patterns;

using OneOf;
using OneOf.Types;

internal sealed class NullableArrayArgumentPattern<TElement> : IArgumentPattern<TElement[]?>
{
    private readonly IArgumentPattern<TElement[]> NonNullableCollectionPattern;

    public NullableArrayArgumentPattern(IArgumentPattern<TElement[]> nonNullableCollectionPattern)
    {
        NonNullableCollectionPattern = nonNullableCollectionPattern;
    }

    OneOf<Error, TElement[]?> IArgumentPattern<TElement[]?>.TryMatch(object? argument)
    {
        if (argument is null)
        {
            return OneOf<Error, TElement[]?>.FromT1(null);
        }

        return NonNullableCollectionPattern.TryMatch(argument).Match
        (
            static (error) => error,
            OneOf<Error, TElement[]?>.FromT1
        );
    }
}
