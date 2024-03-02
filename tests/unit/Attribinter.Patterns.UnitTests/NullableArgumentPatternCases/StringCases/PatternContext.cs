namespace Attribinter.Patterns.NullableArgumentPatternCases.StringCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((INullableStringArgumentPatternFactory)new NullableStringArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<string?> Pattern { get; }

    private PatternContext(IArgumentPattern<string?> pattern)
    {
        Pattern = pattern;
    }
}
