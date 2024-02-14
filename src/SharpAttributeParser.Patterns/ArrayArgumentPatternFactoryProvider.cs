namespace SharpAttributeParser.Patterns;

using System;

/// <inheritdoc cref="IArrayArgumentPatternFactoryProvider"/>
public sealed class ArrayArgumentPatternFactoryProvider : IArrayArgumentPatternFactoryProvider
{
    private readonly INonNullableArrayArgumentPatternFactory NonNullable;
    private readonly INullableArrayArgumentPatternFactory Nullable;

    /// <summary>Instantiates a <see cref="ArrayArgumentPatternFactoryProvider"/>, providing factories of <see cref="IArgumentPattern{T}"/> matching array-valued arguments.</summary>
    /// <param name="nonNullable">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable array-valued arguments.</param>
    /// <param name="nullable">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</param>
    public ArrayArgumentPatternFactoryProvider(INonNullableArrayArgumentPatternFactory nonNullable, INullableArrayArgumentPatternFactory nullable)
    {
        NonNullable = nonNullable ?? throw new ArgumentNullException(nameof(nonNullable));
        Nullable = nullable ?? throw new ArgumentNullException(nameof(nullable));
    }

    INonNullableArrayArgumentPatternFactory IArrayArgumentPatternFactoryProvider.NonNullable => NonNullable;
    INullableArrayArgumentPatternFactory IArrayArgumentPatternFactoryProvider.Nullable => Nullable;
}
