namespace SharpAttributeParser.Patterns.NullableArgumentPatternCases.ObjectCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((INullableObjectArgumentPatternFactory)new NullableObjectArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<object?> Pattern { get; }

    private PatternContext(IArgumentPattern<object?> pattern)
    {
        Pattern = pattern;
    }
}
