namespace Attribinter.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching <see cref="bool"/> arguments.</summary>
public interface IBoolArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are of type <see cref="bool"/>.</summary>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<bool> Create();
}
