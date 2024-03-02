namespace Attribinter.Patterns;

using System;
using System.Collections.Generic;

/// <inheritdoc cref="INonNullableReadOnlyArrayArgumentPatternFactory"/>
public sealed class NonNullableReadOnlyArrayArgumentPatternFactory : INonNullableReadOnlyArrayArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="NonNullableReadOnlyArrayArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable read-only array-valued arguments.</summary>
    public NonNullableReadOnlyArrayArgumentPatternFactory() { }

    IArgumentPattern<IReadOnlyList<TElement>> INonNullableReadOnlyArrayArgumentPatternFactory.Create<TElement>(IArgumentPattern<TElement> elementPattern)
    {
        if (elementPattern is null)
        {
            throw new ArgumentNullException(nameof(elementPattern));
        }

        return new NonNullableReadOnlyArrayArgumentPattern<TElement>(elementPattern);
    }
}
