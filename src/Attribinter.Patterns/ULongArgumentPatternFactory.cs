namespace Attribinter.Patterns;

/// <inheritdoc cref="IULongArgumentPatternFactory"/>
public sealed class ULongArgumentPatternFactory : IULongArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="ULongArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="ulong"/> arguments.</summary>
    public ULongArgumentPatternFactory() { }

    IArgumentPattern<ulong> IULongArgumentPatternFactory.Create() => NonNullableArgumentPattern<ulong>.Instance;
}
