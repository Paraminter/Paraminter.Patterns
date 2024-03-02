namespace Attribinter.Patterns.NonNullableArgumentPatternCases.ULongCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((IULongArgumentPatternFactory)new ULongArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<ulong> Pattern { get; }

    private PatternContext(IArgumentPattern<ulong> pattern)
    {
        Pattern = pattern;
    }
}
