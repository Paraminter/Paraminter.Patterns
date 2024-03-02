namespace Attribinter.Patterns.NonNullableArgumentPatternCases.SByteCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((ISByteArgumentPatternFactory)new SByteArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<sbyte> Pattern { get; }

    private PatternContext(IArgumentPattern<sbyte> pattern)
    {
        Pattern = pattern;
    }
}
