namespace Paraminter.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing successful attempts to match arguments to patterns.</summary>
public interface ISuccessfulArgumentPatternMatchResultFactory
{
    /// <summary>Creates a <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing a successful attempt to match an argument to a pattern.</summary>
    /// <typeparam name="TMatchedArgument">The type of the matched argument.</typeparam>
    /// <param name="matchedArgument">The matched argument.</param>
    /// <returns>The created <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/>.</returns>
    public abstract IArgumentPatternMatchResult<TMatchedArgument> Create<TMatchedArgument>(TMatchedArgument matchedArgument);
}
