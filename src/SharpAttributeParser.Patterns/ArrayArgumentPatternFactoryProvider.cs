namespace SharpAttributeParser.Patterns;

using System;

/// <inheritdoc cref="IArrayArgumentPatternFactoryProvider"/>
public sealed class ArrayArgumentPatternFactoryProvider : IArrayArgumentPatternFactoryProvider
{
    private readonly INonNullableArrayArgumentPatternFactoryProvider NonNullable;
    private readonly INullableArrayArgumentPatternFactoryProvider Nullable;

    /// <summary>Instantiates a <see cref="ArrayArgumentPatternFactoryProvider"/>, providing factories of <see cref="IArgumentPattern{T}"/> matching array-valued arguments.</summary>
    /// <param name="nonNullable">Provides factories of <see cref="IArgumentPattern{T}"/> matching non-nullable array-valued arguments.</param>
    /// <param name="nullable">Provides factories of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</param>
    public ArrayArgumentPatternFactoryProvider(INonNullableArrayArgumentPatternFactoryProvider nonNullable, INullableArrayArgumentPatternFactoryProvider nullable)
    {
        NonNullable = nonNullable ?? throw new ArgumentNullException(nameof(nonNullable));
        Nullable = nullable ?? throw new ArgumentNullException(nameof(nullable));
    }

    INonNullableArrayArgumentPatternFactoryProvider IArrayArgumentPatternFactoryProvider.NonNullable => NonNullable;
    INullableArrayArgumentPatternFactoryProvider IArrayArgumentPatternFactoryProvider.Nullable => Nullable;
}
