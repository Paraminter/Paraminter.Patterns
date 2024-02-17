namespace SharpAttributeParser.Patterns;

using System;
using System.Collections.Generic;

/// <inheritdoc cref="INonNullableReadWriteArrayArgumentPatternFactory"/>
public sealed class NonNullableReadWriteArrayArgumentPatternFactory : INonNullableReadWriteArrayArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="NonNullableReadWriteArrayArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable array-valued arguments.</summary>
    public NonNullableReadWriteArrayArgumentPatternFactory() { }

    IArgumentPattern<IList<TElement>> INonNullableReadWriteArrayArgumentPatternFactory.Create<TElement>(IArgumentPattern<TElement> elementPattern)
    {
        if (elementPattern is null)
        {
            throw new ArgumentNullException(nameof(elementPattern));
        }

        return new NonNullableReadWriteArrayArgumentPattern<TElement>(elementPattern);
    }
}
