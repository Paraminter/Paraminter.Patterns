namespace SharpAttributeParser.Patterns;

using System;

/// <inheritdoc cref="IStringArgumentPatternFactoryProvider"/>
public sealed class StringArgumentPatternFactoryProvider : IStringArgumentPatternFactoryProvider
{
    private readonly INonNullableStringArgumentPatternFactory NonNullable;
    private readonly INullableStringArgumentPatternFactory Nullable;

    /// <summary>Instantiates a <see cref="StringArgumentPatternFactoryProvider"/>, providing factories of <see cref="IArgumentPattern{T}"/> matching <see cref="string"/> arguments.</summary>
    /// <param name="nonNullable">The factory of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="string"/> arguments.</param>
    /// <param name="nullable">The factory of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="string"/> arguments.</param>
    public StringArgumentPatternFactoryProvider(INonNullableStringArgumentPatternFactory nonNullable, INullableStringArgumentPatternFactory nullable)
    {
        NonNullable = nonNullable ?? throw new ArgumentNullException(nameof(nonNullable));
        Nullable = nullable ?? throw new ArgumentNullException(nameof(nullable));
    }

    INonNullableStringArgumentPatternFactory IStringArgumentPatternFactoryProvider.NonNullable => NonNullable;
    INullableStringArgumentPatternFactory IStringArgumentPatternFactoryProvider.Nullable => Nullable;
}
