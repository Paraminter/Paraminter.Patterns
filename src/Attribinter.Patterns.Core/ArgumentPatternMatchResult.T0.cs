namespace Attribinter.Patterns;

/// <summary>Handles creation of <see cref="ArgumentPatternMatchResult{T}"/>.</summary>
public static class ArgumentPatternMatchResult
{
    /// <summary>Creates a <see cref="ArgumentPatternMatchResult{T}"/> describing an unsuccessful attempt to match an argument to a <see cref="IArgumentPattern{TIn, TOut}"/>.</summary>
    /// <typeparam name="T">The type of the matched arguments.</typeparam>
    /// <returns>The created <see cref="ArgumentPatternMatchResult{T}"/>.</returns>
    public static ArgumentPatternMatchResult<T> CreateUnsuccessful<T>() => new();

    /// <summary>Creates a <see cref="ArgumentPatternMatchResult{T}"/> describing a successful attempt to match an argument to a <see cref="IArgumentPattern{TIn, TOut}"/>.</summary>
    /// <typeparam name="T">The type of the matched arguments.</typeparam>
    /// <param name="matchedArgument">The matched argument.</param>
    /// <returns>The created <see cref="ArgumentPatternMatchResult{T}"/>.</returns>
    public static ArgumentPatternMatchResult<T> CreateSuccessful<T>(T matchedArgument) => new(matchedArgument);
}
