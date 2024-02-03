namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.LongCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((ILongArgumentPatternFactory)new LongArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<long> Pattern { get; }

    private PatternContext(IArgumentPattern<long> pattern)
    {
        Pattern = pattern;
    }
}
