namespace Attribinter.Patterns;

using System.Collections.Generic;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching nullable read-only array-valued arguments.</summary>
public interface INullableReadOnlyArrayArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are either <see langword="null"/> or arrays with elements that all match the provided pattern.</summary>
    /// <typeparam name="TElement">The element-type of the arguments matched by the created pattern.</typeparam>
    /// <param name="elementPattern">The pattern of each element of the matched arguments.</param>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<IReadOnlyList<TElement>?> Create<TElement>(IArgumentPattern<TElement> elementPattern);
}
