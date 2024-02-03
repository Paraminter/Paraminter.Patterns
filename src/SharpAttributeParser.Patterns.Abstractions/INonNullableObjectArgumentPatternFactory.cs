namespace SharpAttributeParser.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="object"/> arguments.</summary>
public interface INonNullableObjectArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are of type <see cref="object"/>.</summary>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<object> Create();
}
