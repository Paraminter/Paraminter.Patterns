namespace Attribinter.Patterns;

/// <inheritdoc cref="INullableObjectArgumentPatternFactory"/>
public sealed class NullableObjectArgumentPatternFactory : INullableObjectArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="NullableObjectArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="object"/> arguments.</summary>
    public NullableObjectArgumentPatternFactory() { }

    IArgumentPattern<object?> INullableObjectArgumentPatternFactory.Create() => NullableArgumentPattern<object>.Instance;
}
