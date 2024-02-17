namespace SharpAttributeParser.Patterns.PatternMatchResultCases;

using Xunit;

public sealed class Constructor_MatchedArgument
{
    private static PatternMatchResult<T> Target<T>(T matchedArgument) => new(matchedArgument);

    [Fact]
    public void WasSuccessful()
    {
        var result = Target(42);

        Assert.True(result.WasSuccessful);
    }
}
