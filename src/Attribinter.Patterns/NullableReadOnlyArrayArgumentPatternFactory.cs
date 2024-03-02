namespace Attribinter.Patterns;

using System;
using System.Collections.Generic;

/// <inheritdoc cref="INullableReadOnlyArrayArgumentPatternFactory"/>
public sealed class NullableReadOnlyArrayArgumentPatternFactory : INullableReadOnlyArrayArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="NullableReadOnlyArrayArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</summary>
    public NullableReadOnlyArrayArgumentPatternFactory() { }

    IArgumentPattern<IReadOnlyList<TElement>?> INullableReadOnlyArrayArgumentPatternFactory.Create<TElement>(IArgumentPattern<TElement> elementPattern)
    {
        if (elementPattern is null)
        {
            throw new ArgumentNullException(nameof(elementPattern));
        }

        var nonNullablePattern = new NonNullableReadOnlyArrayArgumentPattern<TElement>(elementPattern);

        return new NullableReadOnlyArrayArgumentPattern<TElement>(nonNullablePattern);
    }
}
