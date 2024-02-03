namespace SharpAttributeParser.Patterns;

using Microsoft.CodeAnalysis;

using System;

/// <inheritdoc cref="INullableTypeArgumentPatternFactory"/>
public sealed class NullableTypeArgumentPatternFactory : INullableTypeArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="NullableTypeArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="ITypeSymbol"/> arguments.</summary>
    /// <remarks>Attribute arguments of type <see cref="Type"/> will match the created patterns, as Roslyn uses <see cref="ITypeSymbol"/> to represent <see cref="Type"/>.</remarks>
    public NullableTypeArgumentPatternFactory() { }

    IArgumentPattern<ITypeSymbol?> INullableTypeArgumentPatternFactory.Create() => NullableArgumentPattern<ITypeSymbol>.Instance;
}
