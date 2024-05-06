namespace Paraminter.Patterns.UnsuccessfulArgumentPatternMatchResultFactoryCases.ArgumentPatternMatchResultCases;

internal static class ResultFixtureFactory
{
    public static IResultFixture<TMatchedArgument> Create<TMatchedArgument>()
    {
        IUnsuccessfulArgumentPatternMatchResultFactory factory = new UnsuccessfulArgumentPatternMatchResultFactory();

        var sut = factory.Create<TMatchedArgument>();

        return new ResultFixture<TMatchedArgument>(sut);
    }

    private sealed class ResultFixture<TMatchedArgument> : IResultFixture<TMatchedArgument>
    {
        private readonly IArgumentPatternMatchResult<TMatchedArgument> Sut;

        public ResultFixture(IArgumentPatternMatchResult<TMatchedArgument> sut)
        {
            Sut = sut;
        }

        IArgumentPatternMatchResult<TMatchedArgument> IResultFixture<TMatchedArgument>.Sut => Sut;
    }
}
