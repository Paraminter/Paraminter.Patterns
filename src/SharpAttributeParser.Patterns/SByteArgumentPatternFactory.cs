namespace SharpAttributeParser.Patterns;

/// <inheritdoc cref="ISByteArgumentPatternFactory"/>
public sealed class SByteArgumentPatternFactory : ISByteArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="SByteArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="sbyte"/> arguments.</summary>
    public SByteArgumentPatternFactory() { }

    IArgumentPattern<sbyte> ISByteArgumentPatternFactory.Create() => NonNullableArgumentPattern<sbyte>.Instance;
}
