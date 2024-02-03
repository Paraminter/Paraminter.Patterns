namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.IntCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((IIntArgumentPatternFactory)new IntArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<int> Pattern { get; }

    private PatternContext(IArgumentPattern<int> pattern)
    {
        Pattern = pattern;
    }
}
