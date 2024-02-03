namespace SharpAttributeParser.Patterns;

/// <inheritdoc cref="IUShortArgumentPatternFactory"/>
public sealed class UShortArgumentPatternFactory : IUShortArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="UShortArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="ushort"/> arguments.</summary>
    public UShortArgumentPatternFactory() { }

    IArgumentPattern<ushort> IUShortArgumentPatternFactory.Create() => NonNullableArgumentPattern<ushort>.Instance;
}
