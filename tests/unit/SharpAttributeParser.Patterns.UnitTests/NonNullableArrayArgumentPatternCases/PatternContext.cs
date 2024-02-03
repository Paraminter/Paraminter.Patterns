namespace SharpAttributeParser.Patterns.NonNullableArrayArgumentPatternCases;

internal sealed class PatternContext<TElement>
{
    public static PatternContext<TElement> Create(IArgumentPattern<TElement> elementPattern)
    {
        var pattern = ((INonNullableArrayArgumentPatternFactory)new NonNullableArrayArgumentPatternFactory()).Create(elementPattern);

        return new(pattern);
    }

    public IArgumentPattern<TElement[]> Pattern { get; }

    private PatternContext(IArgumentPattern<TElement[]> pattern)
    {
        Pattern = pattern;
    }
}
