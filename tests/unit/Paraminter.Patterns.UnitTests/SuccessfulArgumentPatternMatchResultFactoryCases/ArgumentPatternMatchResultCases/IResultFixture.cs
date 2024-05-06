namespace Paraminter.Patterns.SuccessfulArgumentPatternMatchResultFactoryCases.ArgumentPatternMatchResultCases;

using Moq;

internal interface IResultFixture<TMatchedArgument>
    where TMatchedArgument : class
{
    public abstract IArgumentPatternMatchResult<TMatchedArgument> Sut { get; }

    public abstract Mock<TMatchedArgument> MatchedArgumentMock { get; }
}
