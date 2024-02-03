namespace SharpAttributeParser.Patterns;

/// <inheritdoc cref="IDoubleArgumentPatternFactory"/>
public sealed class DoubleArgumentPatternFactory : IDoubleArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="DoubleArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="double"/> arguments.</summary>
    public DoubleArgumentPatternFactory() { }

    IArgumentPattern<double> IDoubleArgumentPatternFactory.Create() => NonNullableArgumentPattern<double>.Instance;
}
