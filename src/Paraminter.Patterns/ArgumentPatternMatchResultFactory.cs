namespace Paraminter.Patterns;

/// <inheritdoc cref="IArgumentPatternMatchResultFactory"/>
public sealed class ArgumentPatternMatchResultFactory : IArgumentPatternMatchResultFactory
{
    private readonly IArgumentPatternMatchResultFactoryProvider FactoryProvider;

    /// <summary>Instantiates a <see cref="ArgumentPatternMatchResultFactory"/>, handling creation of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/>.</summary>
    /// <param name="factoryProvider">Provides factories of <see cref="IArgumentPatternMatchResult{TMatchedArgument}"/>.</param>
    public ArgumentPatternMatchResultFactory(IArgumentPatternMatchResultFactoryProvider factoryProvider)
    {
        FactoryProvider = factoryProvider ?? throw new System.ArgumentNullException(nameof(factoryProvider));
    }

    IArgumentPatternMatchResult<TMatchedArgument> IArgumentPatternMatchResultFactory.CreateSuccessful<TMatchedArgument>(TMatchedArgument matchedArgument) => FactoryProvider.Successful.Create(matchedArgument);
    IArgumentPatternMatchResult<TMatchedArgument> IArgumentPatternMatchResultFactory.CreateUnsuccessful<TMatchedArgument>() => FactoryProvider.Unsuccessful.Create<TMatchedArgument>();
}
