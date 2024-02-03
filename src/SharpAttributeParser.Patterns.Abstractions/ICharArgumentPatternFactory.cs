namespace SharpAttributeParser.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching <see cref="char"/> arguments.</summary>
public interface ICharArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are of type <see cref="char"/>.</summary>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<char> Create();
}
