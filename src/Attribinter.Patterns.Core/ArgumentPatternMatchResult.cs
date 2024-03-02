namespace Attribinter.Patterns;

using System;

/// <summary>Handles creation of <see cref="ArgumentPatternMatchResult{T}"/>.</summary>
public static class ArgumentPatternMatchResult
{
    /// <summary>Creates a <see cref="ArgumentPatternMatchResult{T}"/> describing an unsuccessful attempt to match an argument to a <see cref="IArgumentPattern{T}"/>.</summary>
    /// <typeparam name="T">The type of the matched arguments.</typeparam>
    /// <returns>The created <see cref="ArgumentPatternMatchResult{T}"/>.</returns>
    public static ArgumentPatternMatchResult<T> CreateUnsuccessful<T>() => new();

    /// <summary>Creates a <see cref="ArgumentPatternMatchResult{T}"/> describing a successful attempt to match an argument to a <see cref="IArgumentPattern{T}"/>.</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="matchedArgument">The matched argument.</param>
    /// <returns>The created <see cref="ArgumentPatternMatchResult{T}"/>.</returns>
    public static ArgumentPatternMatchResult<T> CreateSuccessful<T>(T matchedArgument) => new(matchedArgument);
}

/// <summary>Describes the outcome of an attempt to match an argument to a <see cref="IArgumentPattern{T}"/>.</summary>
/// <typeparam name="T">The type of the matched arguments.</typeparam>
public readonly struct ArgumentPatternMatchResult<T>
{
    private readonly T MatchedArgument;

    /// <summary>Indicates whether the attempt was successful.</summary>
    public bool Successful { get; }

    /// <summary>Creates a <see cref="ArgumentPatternMatchResult{T}"/> describing an unsuccessful attempt to match an argument to a <see cref="IArgumentPattern{T}"/>.</summary>
    public ArgumentPatternMatchResult() : this(false, default!) { }

    internal ArgumentPatternMatchResult(T matchedArgument) : this(true, matchedArgument) { }

    private ArgumentPatternMatchResult(bool wasSuccessful, T matchedArgument)
    {
        Successful = wasSuccessful;
        MatchedArgument = matchedArgument;
    }

    /// <summary>Retrieves the matched argument. Throws an <see cref="InvalidOperationException"/> if the attempt was unsuccessful.</summary>
    /// <returns>The matched argument.</returns>
    public T GetMatchedArgument()
    {
        if (Successful is false)
        {
            throw new InvalidOperationException("Cannot retrieve the matched argument, as the attempt was unsuccessful.");
        }

        return MatchedArgument;
    }
}
