namespace Attribinter.Patterns;

/// <summary>Represents a pattern used to match attribute arguments.</summary>
/// <typeparam name="TIn">The type of the attribute arguments being matched.</typeparam>
/// <typeparam name="TOut">The type of the matched attribute arguments.</typeparam>
public interface IArgumentPattern<in TIn, TOut>
{
    /// <summary>Attempts to match the provided argument to the pattern.</summary>
    /// <param name="argument">The argument that is matched to the pattern.</param>
    /// <returns>A <see cref="ArgumentPatternMatchResult{T}"/> describing the outcome.</returns>
    public abstract ArgumentPatternMatchResult<TOut> TryMatch(TIn argument);
}
