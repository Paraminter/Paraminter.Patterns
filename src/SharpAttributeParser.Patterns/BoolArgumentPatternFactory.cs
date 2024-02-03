namespace SharpAttributeParser.Patterns;

/// <inheritdoc cref="IBoolArgumentPatternFactory"/>
public sealed class BoolArgumentPatternFactory : IBoolArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="BoolArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="bool"/> arguments.</summary>
    public BoolArgumentPatternFactory() { }

    IArgumentPattern<bool> IBoolArgumentPatternFactory.Create() => NonNullableArgumentPattern<bool>.Instance;
}
