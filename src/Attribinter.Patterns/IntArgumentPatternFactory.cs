namespace Attribinter.Patterns;

/// <inheritdoc cref="IIntArgumentPatternFactory"/>
public sealed class IntArgumentPatternFactory : IIntArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="IntArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="int"/> arguments.</summary>
    public IntArgumentPatternFactory() { }

    IArgumentPattern<int> IIntArgumentPatternFactory.Create() => NonNullableArgumentPattern<int>.Instance;
}
