namespace SharpAttributeParser.Patterns;

using System;

/// <inheritdoc cref="ITypeArgumentPatternFactoryProvider"/>
public sealed class TypeArgumentPatternFactoryProvider : ITypeArgumentPatternFactoryProvider
{
    private readonly INonNullableTypeArgumentPatternFactory NonNullable;
    private readonly INullableTypeArgumentPatternFactory Nullable;

    /// <summary>Instantiates a <see cref="TypeArgumentPatternFactoryProvider"/>, providing factories of <see cref="IArgumentPattern{T}"/> matching <see cref="Type"/> arguments.</summary>
    /// <param name="nonNullable">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="Type"/> arguments.</param>
    /// <param name="nullable">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="Type"/> arguments.</param>
    public TypeArgumentPatternFactoryProvider(INonNullableTypeArgumentPatternFactory nonNullable, INullableTypeArgumentPatternFactory nullable)
    {
        NonNullable = nonNullable ?? throw new ArgumentNullException(nameof(nonNullable));
        Nullable = nullable ?? throw new ArgumentNullException(nameof(nullable));
    }

    INonNullableTypeArgumentPatternFactory ITypeArgumentPatternFactoryProvider.NonNullable => NonNullable;
    INullableTypeArgumentPatternFactory ITypeArgumentPatternFactoryProvider.Nullable => Nullable;
}
