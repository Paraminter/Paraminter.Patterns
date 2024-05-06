namespace Paraminter.Patterns;

/// <inheritdoc cref="IArgumentPatternMatchResultFactoryProvider"/>
public sealed class ArgumentPatternMatchResultFactoryProvider : IArgumentPatternMatchResultFactoryProvider
{
    private readonly ISuccessfulArgumentPatternMatchResultFactory Successful;
    private readonly IUnsuccessfulArgumentPatternMatchResultFactory Unsuccessful;

    /// <summary>Instantiates a <see cref="ArgumentPatternMatchResultFactoryProvider"/>, providing factories of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/>.</summary>
    /// <param name="successful">Handles creation of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing successful attempts to match arguments to patterns.</param>
    /// <param name="unsuccessful">Handles creation of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/> describing unsuccessful attempts to match arguments to patterns.</param>
    public ArgumentPatternMatchResultFactoryProvider(ISuccessfulArgumentPatternMatchResultFactory successful, IUnsuccessfulArgumentPatternMatchResultFactory unsuccessful)
    {
        Successful = successful ?? throw new System.ArgumentNullException(nameof(successful));
        Unsuccessful = unsuccessful ?? throw new System.ArgumentNullException(nameof(unsuccessful));
    }

    ISuccessfulArgumentPatternMatchResultFactory IArgumentPatternMatchResultFactoryProvider.Successful => Successful;
    IUnsuccessfulArgumentPatternMatchResultFactory IArgumentPatternMatchResultFactoryProvider.Unsuccessful => Unsuccessful;
}
