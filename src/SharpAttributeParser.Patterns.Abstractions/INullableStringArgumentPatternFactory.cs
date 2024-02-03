namespace SharpAttributeParser.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="string"/> arguments.</summary>
public interface INullableStringArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are either <see langword="null"/> or of type <see cref="string"/>.</summary>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<string?> Create();
}
