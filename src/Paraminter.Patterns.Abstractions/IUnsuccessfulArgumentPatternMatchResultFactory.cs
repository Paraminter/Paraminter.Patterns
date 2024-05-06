namespace Paraminter.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing unsuccessful attempts to match arguments to patterns.</summary>
public interface IUnsuccessfulArgumentPatternMatchResultFactory
{
    /// <summary>Creates a <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing an unsuccessful attempt to match an argument to a pattern.</summary>
    /// <typeparam name="TMatchedArgument">The type of the matched argument, had the attempt been successful.</typeparam>
    /// <returns>The created <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/>.</returns>
    public abstract IArgumentPatternMatchResult<TMatchedArgument> Create<TMatchedArgument>();
}
