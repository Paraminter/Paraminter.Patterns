namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.ObjectCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((INonNullableObjectArgumentPatternFactory)new NonNullableObjectArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<object> Pattern { get; }

    private PatternContext(IArgumentPattern<object> pattern)
    {
        Pattern = pattern;
    }
}
