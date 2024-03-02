namespace Attribinter.Patterns;

/// <inheritdoc cref="INullableStringArgumentPatternFactory"/>
public sealed class NullableStringArgumentPatternFactory : INullableStringArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="NullableStringArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="string"/> arguments.</summary>
    public NullableStringArgumentPatternFactory() { }

    IArgumentPattern<string?> INullableStringArgumentPatternFactory.Create() => NullableArgumentPattern<string>.Instance;
}
