namespace SharpAttributeParser.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="object"/> arguments.</summary>
public interface INullableObjectArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are either <see langword="null"/> or of type <see cref="object"/>.</summary>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<object?> Create();
}
