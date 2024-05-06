namespace Paraminter.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/>.</summary>
public interface IArgumentPatternMatchResultFactory
{
    /// <summary>Creates a <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing a successful attempt to match an argument to a pattern.</summary>
    /// <typeparam name="TMatchedArgument">The type of the matched argument.</typeparam>
    /// <param name="matchedArgument">The matched argument.</param>
    /// <returns>The created <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/>.</returns>
    public abstract IArgumentPatternMatchResult<TMatchedArgument> CreateSuccessful<TMatchedArgument>(TMatchedArgument matchedArgument);

    /// <summary>Creates a <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing an unsuccessful attempt to match an argument to a pattern.</summary>
    /// <typeparam name="TMatchedArgument">The type of the matched argument, had the attempt been successful.</typeparam>
    /// <returns>The created <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/>.</returns>
    public abstract IArgumentPatternMatchResult<TMatchedArgument> CreateUnsuccessful<TMatchedArgument>();
}
