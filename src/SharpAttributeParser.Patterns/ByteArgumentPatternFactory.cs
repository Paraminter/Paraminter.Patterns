namespace SharpAttributeParser.Patterns;

/// <inheritdoc cref="IByteArgumentPatternFactory"/>
public sealed class ByteArgumentPatternFactory : IByteArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="ByteArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="byte"/> arguments.</summary>
    public ByteArgumentPatternFactory() { }

    IArgumentPattern<byte> IByteArgumentPatternFactory.Create() => NonNullableArgumentPattern<byte>.Instance;
}
