namespace Attribinter.Patterns;

/// <inheritdoc cref="ICharArgumentPatternFactory"/>
public sealed class CharArgumentPatternFactory : ICharArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="CharArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="char"/> arguments.</summary>
    public CharArgumentPatternFactory() { }

    IArgumentPattern<char> ICharArgumentPatternFactory.Create() => NonNullableArgumentPattern<char>.Instance;
}
