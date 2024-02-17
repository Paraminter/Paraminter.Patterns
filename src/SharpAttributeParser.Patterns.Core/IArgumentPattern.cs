namespace SharpAttributeParser.Patterns;

/// <summary>Represents a pattern used to match attribute arguments.</summary>
/// <typeparam name="T">The type of the attribute arguments matched by the pattern.</typeparam>
public interface IArgumentPattern<T>
{
    /// <summary>Attempts to match the provided <see cref="object"/> to the pattern.</summary>
    /// <param name="argument">The <see cref="object"/> that is matched to the pattern.</param>
    /// <returns>A <see cref="PatternMatchResult{T}"/> describing the outcome.</returns>
    public abstract PatternMatchResult<T> TryMatch(object? argument);
}
