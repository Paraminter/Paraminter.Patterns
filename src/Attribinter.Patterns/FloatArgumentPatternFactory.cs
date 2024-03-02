namespace Attribinter.Patterns;

/// <inheritdoc cref="IFloatArgumentPatternFactory"/>
public sealed class FloatArgumentPatternFactory : IFloatArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="FloatArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="float"/> arguments.</summary>
    public FloatArgumentPatternFactory() { }

    IArgumentPattern<float> IFloatArgumentPatternFactory.Create() => NonNullableArgumentPattern<float>.Instance;
}
