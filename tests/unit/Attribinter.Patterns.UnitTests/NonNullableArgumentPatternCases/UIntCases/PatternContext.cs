namespace Attribinter.Patterns.NonNullableArgumentPatternCases.UIntCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((IUIntArgumentPatternFactory)new UIntArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<uint> Pattern { get; }

    private PatternContext(IArgumentPattern<uint> pattern)
    {
        Pattern = pattern;
    }
}
