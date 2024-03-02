namespace Attribinter.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching <see cref="ulong"/> arguments.</summary>
public interface IULongArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are of type <see cref="ulong"/>.</summary>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<ulong> Create();
}
