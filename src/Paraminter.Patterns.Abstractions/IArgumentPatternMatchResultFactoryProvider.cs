namespace Paraminter.Patterns;

/// <summary>Provides factories of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/>.</summary>
public interface IArgumentPatternMatchResultFactoryProvider
{
    /// <summary>The factory handling creation of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing successful attempts to match arguments to patterns.</summary>
    public abstract ISuccessfulArgumentPatternMatchResultFactory Successful { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing unsuccessful attempts to match arguments to patterns.</summary>
    public abstract IUnsuccessfulArgumentPatternMatchResultFactory Unsuccessful { get; }
}
