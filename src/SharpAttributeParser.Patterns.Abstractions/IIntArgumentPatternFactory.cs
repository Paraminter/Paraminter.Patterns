namespace SharpAttributeParser.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching <see cref="int"/> arguments.</summary>
public interface IIntArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are of type <see cref="int"/>.</summary>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<int> Create();
}
