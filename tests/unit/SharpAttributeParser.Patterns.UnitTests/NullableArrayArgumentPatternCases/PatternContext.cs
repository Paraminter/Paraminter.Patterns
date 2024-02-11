namespace SharpAttributeParser.Patterns.NullableArrayArgumentPatternCases;

using System.Collections.Generic;

internal sealed class PatternContext<TElement>
{
    public static PatternContext<TElement> Create(IArgumentPattern<TElement> elementPattern)
    {
        var pattern = ((INullableArrayArgumentPatternFactory)new NullableArrayArgumentPatternFactory()).Create(elementPattern);

        return new(pattern);
    }

    public IArgumentPattern<IList<TElement>?> Pattern { get; }

    private PatternContext(IArgumentPattern<IList<TElement>?> pattern)
    {
        Pattern = pattern;
    }
}
