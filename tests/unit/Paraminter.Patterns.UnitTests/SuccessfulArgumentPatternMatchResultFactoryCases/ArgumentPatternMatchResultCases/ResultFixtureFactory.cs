namespace Paraminter.Patterns.SuccessfulArgumentPatternMatchResultFactoryCases.ArgumentPatternMatchResultCases;

using Moq;

internal static class ResultFixtureFactory
{
    public static IResultFixture<TMatchedArgument> Create<TMatchedArgument>()
        where TMatchedArgument : class
    {
        Mock<TMatchedArgument> matchedArgumentMock = new();

        ISuccessfulArgumentPatternMatchResultFactory factory = new SuccessfulArgumentPatternMatchResultFactory();

        var sut = factory.Create(matchedArgumentMock.Object);

        return new ResultFixture<TMatchedArgument>(sut, matchedArgumentMock);
    }

    private sealed class ResultFixture<TMatchedArgument>
        : IResultFixture<TMatchedArgument>
        where TMatchedArgument : class
    {
        private readonly IArgumentPatternMatchResult<TMatchedArgument> Sut;

        private readonly Mock<TMatchedArgument> MatchedArgumentMock;

        public ResultFixture(
            IArgumentPatternMatchResult<TMatchedArgument> sut,
            Mock<TMatchedArgument> matchedArgumentMock)
        {
            Sut = sut;

            MatchedArgumentMock = matchedArgumentMock;
        }

        IArgumentPatternMatchResult<TMatchedArgument> IResultFixture<TMatchedArgument>.Sut => Sut;

        Mock<TMatchedArgument> IResultFixture<TMatchedArgument>.MatchedArgumentMock => MatchedArgumentMock;
    }
}
