namespace SharpAttributeParser.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching <see cref="sbyte"/> arguments.</summary>
public interface ISByteArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are of type <see cref="sbyte"/>.</summary>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<sbyte> Create();
}
