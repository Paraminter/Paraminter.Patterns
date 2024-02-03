namespace SharpAttributeParser.Patterns;

using Microsoft.CodeAnalysis;

using System;

/// <inheritdoc cref="INonNullableTypeArgumentPatternFactory"/>
public sealed class NonNullableTypeArgumentPatternFactory : INonNullableTypeArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="NonNullableTypeArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="ITypeSymbol"/> arguments.</summary>
    /// <remarks>Attribute arguments of type <see cref="Type"/> will match the created patterns, as Roslyn uses <see cref="ITypeSymbol"/> to represent <see cref="Type"/>.</remarks>
    public NonNullableTypeArgumentPatternFactory() { }

    IArgumentPattern<ITypeSymbol> INonNullableTypeArgumentPatternFactory.Create() => NonNullableArgumentPattern<ITypeSymbol>.Instance;
}
