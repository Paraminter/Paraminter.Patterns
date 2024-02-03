namespace SharpAttributeParser.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching <see cref="float"/> arguments.</summary>
public interface IFloatArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are of type <see cref="float"/>.</summary>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<float> Create();
}
