namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.CharCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((ICharArgumentPatternFactory)new CharArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<char> Pattern { get; }

    private PatternContext(IArgumentPattern<char> pattern)
    {
        Pattern = pattern;
    }
}
