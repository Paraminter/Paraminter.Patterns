namespace Paraminter.Patterns;

/// <summary>Represents a pattern used to match arguments.</summary>
/// <typeparam name="TIn">The type of the arguments being matched.</typeparam>
/// <typeparam name="TOut">The type of the matched arguments.</typeparam>
public interface IArgumentPattern<in TIn, out TOut>
{
    /// <summary>Attempts to match the provided argument to the pattern.</summary>
    /// <param name="argument">The argument that is matched to the pattern.</param>
    /// <returns>An <see cref="IArgumentPatternMatchResult{T}"/> describing the outcome.</returns>
    public abstract IArgumentPatternMatchResult<TOut> TryMatch(
        TIn argument);
}
