namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.StringCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((INonNullableStringArgumentPatternFactory)new NonNullableStringArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<string> Pattern { get; }

    private PatternContext(IArgumentPattern<string> pattern)
    {
        Pattern = pattern;
    }
}
