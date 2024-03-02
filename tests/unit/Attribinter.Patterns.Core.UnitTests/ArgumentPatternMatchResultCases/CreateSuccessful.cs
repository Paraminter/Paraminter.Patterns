namespace Attribinter.Patterns.ArgumentPatternMatchResultCases;

using Xunit;

public sealed class CreateSuccessful
{
    private static ArgumentPatternMatchResult<T> Target<T>(T matchedArgument) => ArgumentPatternMatchResult.CreateSuccessful(matchedArgument);

    [Fact]
    public void Successful_Is_True()
    {
        var result = Target(42);

        Assert.True(result.Successful);
    }
}
