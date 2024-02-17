namespace SharpAttributeParser.Patterns;

using System;

/// <inheritdoc cref="IObjectArgumentPatternFactoryProvider"/>
public sealed class ObjectArgumentPatternFactoryProvider : IObjectArgumentPatternFactoryProvider
{
    private readonly INonNullableObjectArgumentPatternFactory NonNullable;
    private readonly INullableObjectArgumentPatternFactory Nullable;

    /// <summary>Instantiates a <see cref="ObjectArgumentPatternFactoryProvider"/>, providing factories of <see cref="IArgumentPattern{T}"/> matching <see cref="object"/> arguments.</summary>
    /// <param name="nonNullable">The factory of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="object"/> arguments.</param>
    /// <param name="nullable">The factory of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="object"/> arguments.</param>
    public ObjectArgumentPatternFactoryProvider(INonNullableObjectArgumentPatternFactory nonNullable, INullableObjectArgumentPatternFactory nullable)
    {
        NonNullable = nonNullable ?? throw new ArgumentNullException(nameof(nonNullable));
        Nullable = nullable ?? throw new ArgumentNullException(nameof(nullable));
    }

    INonNullableObjectArgumentPatternFactory IObjectArgumentPatternFactoryProvider.NonNullable => NonNullable;
    INullableObjectArgumentPatternFactory IObjectArgumentPatternFactoryProvider.Nullable => Nullable;
}
