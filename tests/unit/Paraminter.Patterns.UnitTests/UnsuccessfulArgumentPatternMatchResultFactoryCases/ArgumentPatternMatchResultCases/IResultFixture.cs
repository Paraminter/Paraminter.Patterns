namespace Paraminter.Patterns.UnsuccessfulArgumentPatternMatchResultFactoryCases.ArgumentPatternMatchResultCases;

internal interface IResultFixture<TMatchedArgument>
{
    public abstract IArgumentPatternMatchResult<TMatchedArgument> Sut { get; }
}
