namespace Attribinter.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching <see cref="uint"/> arguments.</summary>
public interface IUIntArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are of type <see cref="uint"/>.</summary>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<uint> Create();
}
