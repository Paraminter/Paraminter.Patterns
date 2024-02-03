namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.DoubleCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((IDoubleArgumentPatternFactory)new DoubleArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<double> Pattern { get; }

    private PatternContext(IArgumentPattern<double> pattern)
    {
        Pattern = pattern;
    }
}
