namespace Attribinter.Patterns.DelegatedArgumentPatternCases.EnumCases;

using System;

internal sealed class PatternContext<TEnum> where TEnum : Enum
{
    public static PatternContext<TEnum> Create()
    {
        var pattern = ((IEnumArgumentPatternFactory)new EnumArgumentPatternFactory()).Create<TEnum>();

        return new(pattern);
    }

    public IArgumentPattern<TEnum> Pattern { get; }

    private PatternContext(IArgumentPattern<TEnum> pattern)
    {
        Pattern = pattern;
    }
}
