namespace SharpAttributeParser.Patterns;

using System;

/// <summary>Describes the outcome of an attempt to match an argument to a <see cref="IArgumentPattern{T}"/>.</summary>
/// <typeparam name="T">The type of the matched arguments.</typeparam>
public readonly struct PatternMatchResult<T>
{
    private readonly T MatchedArgument;

    /// <summary>Indicates whether the attempt was successful.</summary>
    public bool WasSuccessful { get; }

    /// <summary>Creates a <see cref="PatternMatchResult{T}"/> describing an unsuccessful attempt to match an argument to a <see cref="IArgumentPattern{T}"/>.</summary>
    public PatternMatchResult() : this(false, default!) { }

    /// <summary>Creates a <see cref="PatternMatchResult{T}"/> describing a successful attempt to match an argument to a <see cref="IArgumentPattern{T}"/>.</summary>
    /// <param name="matchedArgument">The matched argument.</param>
    public PatternMatchResult(T matchedArgument) : this(true, matchedArgument) { }

    private PatternMatchResult(bool wasSuccessful, T matchedArgument)
    {
        WasSuccessful = wasSuccessful;
        MatchedArgument = matchedArgument;
    }

    /// <summary>Retrieves the matched argument. Throws an <see cref="InvalidOperationException"/> if the attempt was unsuccessful.</summary>
    /// <returns>The matched argument.</returns>
    public T GetMatchedArgument()
    {
        if (WasSuccessful is false)
        {
            throw new InvalidOperationException("Cannot retrieve the matched argument, as the attempt was unsuccessful.");
        }

        return MatchedArgument;
    }
}
