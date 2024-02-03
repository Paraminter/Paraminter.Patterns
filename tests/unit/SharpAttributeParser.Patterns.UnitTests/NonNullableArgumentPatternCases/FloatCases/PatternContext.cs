namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.FloatCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((IFloatArgumentPatternFactory)new FloatArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<float> Pattern { get; }

    private PatternContext(IArgumentPattern<float> pattern)
    {
        Pattern = pattern;
    }
}
