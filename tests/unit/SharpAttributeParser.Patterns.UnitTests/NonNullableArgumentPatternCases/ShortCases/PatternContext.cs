namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.ShortCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((IShortArgumentPatternFactory)new ShortArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<short> Pattern { get; }

    private PatternContext(IArgumentPattern<short> pattern)
    {
        Pattern = pattern;
    }
}
