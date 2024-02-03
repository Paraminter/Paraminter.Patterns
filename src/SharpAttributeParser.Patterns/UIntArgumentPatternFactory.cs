namespace SharpAttributeParser.Patterns;

/// <inheritdoc cref="IUIntArgumentPatternFactory"/>
public sealed class UIntArgumentPatternFactory : IUIntArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="UIntArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="uint"/> arguments.</summary>
    public UIntArgumentPatternFactory() { }

    IArgumentPattern<uint> IUIntArgumentPatternFactory.Create() => NonNullableArgumentPattern<uint>.Instance;
}
