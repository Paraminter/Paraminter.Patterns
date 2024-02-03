namespace SharpAttributeParser.Patterns;

/// <inheritdoc cref="ILongArgumentPatternFactory"/>
public sealed class LongArgumentPatternFactory : ILongArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="LongArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="long"/> arguments.</summary>
    public LongArgumentPatternFactory() { }

    IArgumentPattern<long> ILongArgumentPatternFactory.Create() => NonNullableArgumentPattern<long>.Instance;
}
