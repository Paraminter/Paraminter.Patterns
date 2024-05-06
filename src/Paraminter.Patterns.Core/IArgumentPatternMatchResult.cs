namespace Paraminter.Patterns;

using System;

/// <summary>Describes the outcome of an attempt to match an argument to a pattern.</summary>
/// <typeparam name="TMatchedArgument">The type of the matched arguments.</typeparam>
public interface IArgumentPatternMatchResult<out TMatchedArgument>
{
    /// <summary>Indicates whether the attempt to match an argument was successful.</summary>
    public abstract bool WasSuccessful { get; }

    /// <summary>Retrieves the matched argument, or throws an <see cref="InvalidOperationException"/> if the attempt to match an argument was unsuccessful.</summary>
    /// <returns>The matched argument, if the attempt to match an argument was successful.</returns>
    public abstract TMatchedArgument GetMatchedArgument();
}
