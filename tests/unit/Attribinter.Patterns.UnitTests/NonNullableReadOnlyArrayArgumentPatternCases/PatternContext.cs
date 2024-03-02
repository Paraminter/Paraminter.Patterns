namespace Attribinter.Patterns.NonNullableReadOnlyArrayArgumentPatternCases;

using System.Collections.Generic;

internal sealed class PatternContext<TElement>
{
    public static PatternContext<TElement> Create(IArgumentPattern<TElement> elementPattern)
    {
        var pattern = ((INonNullableReadOnlyArrayArgumentPatternFactory)new NonNullableReadOnlyArrayArgumentPatternFactory()).Create(elementPattern);

        return new(pattern);
    }

    public IArgumentPattern<IReadOnlyList<TElement>> Pattern { get; }

    private PatternContext(IArgumentPattern<IReadOnlyList<TElement>> pattern)
    {
        Pattern = pattern;
    }
}
