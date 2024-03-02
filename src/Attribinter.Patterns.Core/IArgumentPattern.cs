namespace Attribinter.Patterns;

/// <summary>Represents a pattern used to match attribute arguments.</summary>
/// <typeparam name="T">The type of the attribute arguments matched by the pattern.</typeparam>
public interface IArgumentPattern<T>
{
    /// <summary>Attempts to match the provided argument to the pattern.</summary>
    /// <param name="argument">The argument that is matched to the pattern.</param>
    /// <returns>A <see cref="ArgumentPatternMatchResult{T}"/> describing the outcome.</returns>
    public abstract ArgumentPatternMatchResult<T> TryMatch(object? argument);
}
