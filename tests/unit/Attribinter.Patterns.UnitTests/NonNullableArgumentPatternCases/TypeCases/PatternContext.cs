namespace Attribinter.Patterns.NonNullableArgumentPatternCases.TypeCases;

using Microsoft.CodeAnalysis;

internal sealed class PatternContext
{
    public static PatternContext Create()
    {
        var pattern = ((INonNullableTypeArgumentPatternFactory)new NonNullableTypeArgumentPatternFactory()).Create();

        return new(pattern);
    }

    public IArgumentPattern<ITypeSymbol> Pattern { get; }

    private PatternContext(IArgumentPattern<ITypeSymbol> pattern)
    {
        Pattern = pattern;
    }
}
