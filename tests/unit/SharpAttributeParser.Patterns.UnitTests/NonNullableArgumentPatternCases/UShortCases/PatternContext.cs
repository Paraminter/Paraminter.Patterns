namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.UShortCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((IUShortArgumentPatternFactory)new UShortArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<ushort> Pattern { get; }

    private PatternContext(IArgumentPattern<ushort> pattern)
    {
        Pattern = pattern;
    }
}
