namespace SharpAttributeParser.Patterns;

/// <inheritdoc cref="INonNullableObjectArgumentPatternFactory"/>
public sealed class NonNullableObjectArgumentPatternFactory : INonNullableObjectArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="NonNullableObjectArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="object"/> arguments.</summary>
    public NonNullableObjectArgumentPatternFactory() { }

    IArgumentPattern<object> INonNullableObjectArgumentPatternFactory.Create() => NonNullableArgumentPattern<object>.Instance;
}
