namespace SharpAttributeParser.Patterns;

using System;

/// <inheritdoc cref="INullableArrayArgumentPatternFactory"/>
public sealed class NullableArrayArgumentPatternFactory : INullableArrayArgumentPatternFactory
{
    /// <summary>Instantiates a <see cref="NullableArrayArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</summary>
    public NullableArrayArgumentPatternFactory() { }

    IArgumentPattern<TElement[]?> INullableArrayArgumentPatternFactory.Create<TElement>(IArgumentPattern<TElement> elementPattern)
    {
        if (elementPattern is null)
        {
            throw new ArgumentNullException(nameof(elementPattern));
        }

        var nonNullablePattern = new NonNullableArrayArgumentPattern<TElement>(elementPattern);

        return new NullableArrayArgumentPattern<TElement>(nonNullablePattern);
    }
}
