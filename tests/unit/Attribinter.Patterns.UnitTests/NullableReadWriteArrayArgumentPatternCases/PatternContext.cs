namespace Attribinter.Patterns.NullableReadWriteArrayArgumentPatternCases;

using System.Collections.Generic;

internal sealed class PatternContext<TElement>
{
    public static PatternContext<TElement> Create(IArgumentPattern<TElement> elementPattern)
    {
        var pattern = ((INullableReadWriteArrayArgumentPatternFactory)new NullableReadWriteArrayArgumentPatternFactory()).Create(elementPattern);

        return new(pattern);
    }

    public IArgumentPattern<IList<TElement>?> Pattern { get; }

    private PatternContext(IArgumentPattern<IList<TElement>?> pattern)
    {
        Pattern = pattern;
    }
}
