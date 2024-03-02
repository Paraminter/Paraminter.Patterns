namespace Attribinter.Patterns.ArgumentPatternMatchResultCases;

using Xunit;

public sealed class CreateUnsuccessful
{
    private static ArgumentPatternMatchResult<T> Target<T>() => ArgumentPatternMatchResult.CreateUnsuccessful<T>();

    [Fact]
    public void Successful_Is_False()
    {
        var result = Target<int>();

        Assert.False(result.Successful);
    }
}
