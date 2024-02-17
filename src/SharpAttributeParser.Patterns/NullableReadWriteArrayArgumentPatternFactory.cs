namespace SharpAttributeParser.Patterns;

using System;
using System.Collections.Generic;

/// <inheritdoc cref="INullableReadWriteArrayArgumentPatternFactory"/>
public sealed class NullableReadWriteArrayArgumentPatternFactory : INullableReadWriteArrayArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="NullableReadWriteArrayArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</summary>
    public NullableReadWriteArrayArgumentPatternFactory() { }

    IArgumentPattern<IList<TElement>?> INullableReadWriteArrayArgumentPatternFactory.Create<TElement>(IArgumentPattern<TElement> elementPattern)
    {
        if (elementPattern is null)
        {
            throw new ArgumentNullException(nameof(elementPattern));
        }

        var nonNullablePattern = new NonNullableReadWriteArrayArgumentPattern<TElement>(elementPattern);

        return new NullableReadWriteArrayArgumentPattern<TElement>(nonNullablePattern);
    }
}
