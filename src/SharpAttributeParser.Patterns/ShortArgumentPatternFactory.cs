namespace SharpAttributeParser.Patterns;

/// <inheritdoc cref="IShortArgumentPatternFactory"/>
public sealed class ShortArgumentPatternFactory : IShortArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="ShortArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="short"/> arguments.</summary>
    public ShortArgumentPatternFactory() { }

    IArgumentPattern<short> IShortArgumentPatternFactory.Create() => NonNullableArgumentPattern<short>.Instance;
}
