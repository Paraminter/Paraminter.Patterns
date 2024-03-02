namespace Attribinter.Patterns;

/// <inheritdoc cref="INonNullableStringArgumentPatternFactory"/>
public sealed class NonNullableStringArgumentPatternFactory : INonNullableStringArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="NonNullableStringArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="string"/> arguments.</summary>
    public NonNullableStringArgumentPatternFactory() { }

    IArgumentPattern<string> INonNullableStringArgumentPatternFactory.Create() => NonNullableArgumentPattern<string>.Instance;
}
