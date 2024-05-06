namespace Paraminter.Patterns;

/// <inheritdoc cref="ISuccessfulArgumentPatternMatchResultFactory"/>
public sealed class SuccessfulArgumentPatternMatchResultFactory : ISuccessfulArgumentPatternMatchResultFactory
{
    /// <summary>Instantiates a <see cref="SuccessfulArgumentPatternMatchResultFactory"/>, handling creation of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing successful attempts to match arguments to patterns.</summary>
    public SuccessfulArgumentPatternMatchResultFactory() { }

    IArgumentPatternMatchResult<TMatchedArgument> ISuccessfulArgumentPatternMatchResultFactory.Create<TMatchedArgument>(TMatchedArgument matchedArgument) => new ArgumentPatternMatchResult<TMatchedArgument>(matchedArgument);

    private sealed class ArgumentPatternMatchResult<TMatchedArgument> : IArgumentPatternMatchResult<TMatchedArgument>
    {
        private readonly TMatchedArgument MatchedArgument;

        public ArgumentPatternMatchResult(TMatchedArgument matchedArgument)
        {
            MatchedArgument = matchedArgument;
        }

        bool IArgumentPatternMatchResult<TMatchedArgument>.WasSuccessful => true;

        TMatchedArgument IArgumentPatternMatchResult<TMatchedArgument>.GetMatchedArgument() => MatchedArgument;
    }
}
