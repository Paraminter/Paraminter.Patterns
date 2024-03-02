namespace Attribinter.Patterns.NonNullableArgumentPatternCases.BoolCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((IBoolArgumentPatternFactory)new BoolArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<bool> Pattern { get; }

    private PatternContext(IArgumentPattern<bool> pattern)
    {
        Pattern = pattern;
    }
}
