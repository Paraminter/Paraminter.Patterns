namespace SharpAttributeParser.Patterns.NullableArgumentPatternCases.TypeCases;

using Microsoft.CodeAnalysis;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((INullableTypeArgumentPatternFactory)new NullableTypeArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<ITypeSymbol?> Pattern { get; }

    private PatternContext(IArgumentPattern<ITypeSymbol?> pattern)
    {
        Pattern = pattern;
    }
}
