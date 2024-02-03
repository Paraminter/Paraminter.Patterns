namespace SharpAttributeParser.Patterns.NonNullableArgumentPatternCases.ByteCases;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((IByteArgumentPatternFactory)new ByteArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<byte> Pattern { get; }

    private PatternContext(IArgumentPattern<byte> pattern)
    {
        Pattern = pattern;
    }
}
